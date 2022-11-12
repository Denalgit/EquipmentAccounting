using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    enum RowState
    {
        Eixsted,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        private readonly CheckUser _user;

        private DataBase database = new DataBase();

        public MainForm(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void isAdmin()
        {
            toolStripButtonAdmin.Enabled = _user.IsAdmin;
            toolStripButtonAdmin.Visible = _user.IsAdmin;
        }

        //Создание столбцов таблицы
        private void CreateColumns()
        {
            dataGridViewEquipment.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewEquipment.Columns.Add("ED.IdNameEquip", "Код названия оборудования");
            dataGridViewEquipment.Columns.Add("EquipName","Название оборудования");
            dataGridViewEquipment.Columns.Add("Quantity", "Количество");
            dataGridViewEquipment.Columns.Add("IsNew", String.Empty);   
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew);
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
         
           string queryString = $"SELECT IdEquipment, ED.IdNameEquip, EquipName, Quantity FROM EquipDirectory ED JOIN Equipment E ON ED.IdNameEquip = E.IdNameEquip";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewEquipment.Columns[4].Visible = false;
            database.closeConnection();
        }

        //Загрузка основной формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripTextBoxUserStatus.Text = $"{_user.Status}";
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridViewEquipment);

        }
        //Обработка события нажатия на кнопку выхода
        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result =
                 MessageBox.Show("Выйти из системы?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               this.Close();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                equipmentTableAdapter.FillBy(eQUIPMENT_ACCOUNTINGDataSet.Equipment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Открытие формы справочника оборудования
        private void toolStripButtonEquipDirectory_Click(object sender, EventArgs e)
        {
            FormEquipDirectory EquipDirectory = new FormEquipDirectory();
            EquipDirectory.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }
        //Открытие формы заявок
        private void toolStripButtonApplication_Click(object sender, EventArgs e)
        {
            FormApplication Application = new FormApplication();
            Application.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }
        //Открытие формы сотрудников
        private void toolStripButtonEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee Employee = new FormEmployee(_user);
            Employee.ShowDialog();
        }

        private void toolStripButtonAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin Admin = new FormAdmin();
            Admin.ShowDialog();
        }

        private void toolStripButtonProvider_Click(object sender, EventArgs e)
        {
            FormProvider Provider = new FormProvider(_user);
            Provider.ShowDialog();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder Order = new FormOrder();
            Order.ShowDialog();
        }

        private void ComingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComing Coming = new FormComing();
            Coming.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }

        private void ConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsumption Consumption = new FormConsumption();
            Consumption.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }

        private void WriteOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWriteOff WriteOff = new FormWriteOff();
            WriteOff.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }

        private void BalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBalance Balance = new FormBalance();
            Balance.ShowDialog();
            RefreshDataGrid(dataGridViewEquipment);
        }

        private void toolStripButtonDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment Department = new FormDepartment(_user);
            Department.ShowDialog();
        }
    }
}
