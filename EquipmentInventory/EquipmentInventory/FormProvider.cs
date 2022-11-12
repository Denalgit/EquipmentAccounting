using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormProvider : Form
    {
        private DataBase database = new DataBase();

        private readonly CheckUser _user;

        int selectedRow;

        public FormProvider(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void isAdmin()
        {
            toolStripButtonInsert.Enabled = _user.IsAdmin;
            toolStripButtonDelete.Enabled = _user.IsAdmin;
            ButtonUpdate.Enabled = _user.IsAdmin;
            toolStripButtonInsert.Visible = _user.IsAdmin;
            toolStripButtonDelete.Visible = _user.IsAdmin;
            ButtonUpdate.Visible = _user.IsAdmin;
        }

        //Создание столбцов таблицы
        private void CreateColumns()
        {
            dataGridViewProvider.Columns.Add("IdProvider", "Код поставщика");
            dataGridViewProvider.Columns.Add("CompanyName", "Название компании");
            dataGridViewProvider.Columns.Add("CompanyPhone", "Телефон компании");
            dataGridViewProvider.Columns.Add("FioRepresent", "ФИО представителя");
            dataGridViewProvider.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdProvider.Text = "";
            textBoxCompanyName.Text = "";
            maskedTextBoxCompanyPhone.Text = "";
            textBoxFioRepresent.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Provider";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewProvider.Columns[4].Visible = false;
            database.closeConnection();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProvider_Load(object sender, EventArgs e)
        {
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridViewProvider);
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
             FormInsertProvider ProviderIns = new FormInsertProvider();
            ProviderIns.ShowDialog();
            RefreshDataGrid(dataGridViewProvider);
        }

        private void deleteRow()
        {
            int index = dataGridViewProvider.CurrentCell.RowIndex;

            dataGridViewProvider.Rows[index].Visible = false;

            if (dataGridViewProvider.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewProvider.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridViewProvider.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewProvider.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewProvider.Rows[index].Cells[4].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var IdProvider = Convert.ToInt32(dataGridViewProvider.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Provider WHERE IdProvider = {IdProvider}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdProvider = dataGridViewProvider.Rows[index].Cells[0].Value.ToString();
                    var CompanyName = dataGridViewProvider.Rows[index].Cells[1].Value.ToString();
                    var CompanyPhone = dataGridViewProvider.Rows[index].Cells[2].Value.ToString();
                    var FioRepresent = dataGridViewProvider.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"UPDATE Provider SET CompanyName = '{CompanyName}', CompanyPhone = '{CompanyPhone}', FioRepresent = '{FioRepresent}' WHERE IdProvider = '{IdProvider}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewProvider.CurrentCell.RowIndex;

            var IdProvider = textBoxIdProvider.Text;
            var CompanyName = textBoxCompanyName.Text;
            var CompanyPhone = maskedTextBoxCompanyPhone.Text;
            var FioRepresent = textBoxFioRepresent.Text; 

            if (dataGridViewProvider.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                    dataGridViewProvider.Rows[selectedRowIndex].SetValues(IdProvider, CompanyName, CompanyPhone, FioRepresent);
                    dataGridViewProvider.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Change();
                Update();
                ClearFields();
            }

            catch (SqlException)
            {
                MessageBox.Show("Не удалось изменить запись!", "Запись не изменена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDataGrid(dataGridViewProvider);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteRow();
                Update();
                ClearFields();
            }

            catch (SqlException)
            {
                MessageBox.Show("Не удалось удалить запись!", "Запись не удалена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDataGrid(dataGridViewProvider);
            }
        }

        private void dataGridViewProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProvider.Rows[selectedRow];
                textBoxIdProvider.Text = row.Cells[0].Value.ToString();
                textBoxCompanyName.Text = row.Cells[1].Value.ToString();
                maskedTextBoxCompanyPhone.Text = row.Cells[2].Value.ToString();
                textBoxFioRepresent.Text = row.Cells[3].Value.ToString();

            }
        }

        private void maskedTextBoxCompanyPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
