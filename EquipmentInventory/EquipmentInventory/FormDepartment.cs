using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormDepartment : Form
    {

        private DataBase database = new DataBase();

        private readonly CheckUser _user;

        int selectedRow;

        public FormDepartment(CheckUser user)
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
            dataGridViewDepartment.Columns.Add("IdDepartment", "Код отдела");
            dataGridViewDepartment.Columns.Add("DepartNumber", "Номер отдела");
            dataGridViewDepartment.Columns.Add("DepartmentPhone", "Телефон отдела");
            dataGridViewDepartment.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdDepartment.Text = "";
            textBoxDepartNumber.Text = "";
            maskedTextBoxDepartmentPhone.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Department";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewDepartment.Columns[3].Visible = false;
            database.closeConnection();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridViewDepartment);
        }

        private void deleteRow()
        {
            int index = dataGridViewDepartment.CurrentCell.RowIndex;

            dataGridViewDepartment.Rows[index].Visible = false;

            if (dataGridViewDepartment.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewDepartment.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridViewDepartment.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewDepartment.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewDepartment.Rows[index].Cells[3].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var IdDepartment = Convert.ToInt32(dataGridViewDepartment.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Department WHERE IdDepartment = {IdDepartment}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdDepartment = dataGridViewDepartment.Rows[index].Cells[0].Value.ToString();
                    var DepartNumber = dataGridViewDepartment.Rows[index].Cells[1].Value.ToString();
                    var DepartmentPhone = dataGridViewDepartment.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"UPDATE Provider SET DepartNumber = '{DepartNumber}', DepartmentPhone = '{DepartmentPhone}' WHERE IdDepartment = '{IdDepartment}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewDepartment.CurrentCell.RowIndex;

            var IdDepartment = textBoxIdDepartment.Text;
            var DepartNumber = textBoxDepartNumber.Text;
            var DepartmentPhone = maskedTextBoxDepartmentPhone.Text;

            if (dataGridViewDepartment.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewDepartment.Rows[selectedRowIndex].SetValues(IdDepartment, DepartNumber, DepartmentPhone);
                dataGridViewDepartment.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
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
                RefreshDataGrid(dataGridViewDepartment);
            }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertDepartment DepartmentIns = new FormInsertDepartment();
            DepartmentIns.ShowDialog();
            RefreshDataGrid(dataGridViewDepartment);
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
                RefreshDataGrid(dataGridViewDepartment);
            }
        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDepartment.Rows[selectedRow];
                textBoxIdDepartment.Text = row.Cells[0].Value.ToString();
                textBoxDepartNumber.Text = row.Cells[1].Value.ToString();
                maskedTextBoxDepartmentPhone.Text = row.Cells[2].Value.ToString();
            }
        }

        private void maskedTextBoxDepartmentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
