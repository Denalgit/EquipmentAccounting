using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
   
    public partial class FormEmployee : Form
    {
       private DataBase database = new DataBase();

       private readonly CheckUser _user;

       int selectedRow;

        public FormEmployee(CheckUser user)
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
            dataGridViewEmployee.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewEmployee.Columns.Add("FioEmployee", "ФИО");
            dataGridViewEmployee.Columns.Add("DateBirth", "День рождения");
            dataGridViewEmployee.Columns.Add("Position", "Должность");
            dataGridViewEmployee.Columns.Add("Address", "Адрес");
            dataGridViewEmployee.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdEmployee.Text = "";
            textBoxFioEmployee.Text = "";
            maskedTextBoxDateBirth.Text = "";
            textBoxPosition.Text = "";
            textBoxAddress.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Employee";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewEmployee.Columns[5].Visible = false;
            database.closeConnection();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertEmployee EmployeeIns = new FormInsertEmployee();
            EmployeeIns.ShowDialog();
            RefreshDataGrid(dataGridViewEmployee);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridViewEmployee);
        }

        private void deleteRow()
        {
            int index = dataGridViewEmployee.CurrentCell.RowIndex;

            dataGridViewEmployee.Rows[index].Visible = false;

            if (dataGridViewEmployee.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewEmployee.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridViewEmployee.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewEmployee.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewEmployee.Rows[index].Cells[5].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var IdEmployee = Convert.ToInt32(dataGridViewEmployee.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Employee WHERE IdEmployee = {IdEmployee}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdEmployee = dataGridViewEmployee.Rows[index].Cells[0].Value.ToString();
                    var FioEmployee = dataGridViewEmployee.Rows[index].Cells[1].Value.ToString();
                    var DateBirth = dataGridViewEmployee.Rows[index].Cells[2].Value.ToString();
                    var Position = dataGridViewEmployee.Rows[index].Cells[3].Value.ToString();
                    var Address = dataGridViewEmployee.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"UPDATE Employee SET FioEmployee = '{FioEmployee}', DateBirth = '{DateBirth}', Position = '{Position}', Address = '{Address}' WHERE IdEmployee = '{IdEmployee}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewEmployee.CurrentCell.RowIndex;

            var IdEmployee = textBoxIdEmployee.Text;
            var FioEmployee = textBoxFioEmployee.Text;
            var DateBirth = maskedTextBoxDateBirth.Text;
            var Position = textBoxPosition.Text;
            var Address = textBoxAddress.Text;

            if (dataGridViewEmployee.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewEmployee.Rows[selectedRowIndex].SetValues(IdEmployee, FioEmployee, DateBirth, Position, Address);
                dataGridViewEmployee.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxIdEmployee.Text == "" || textBoxFioEmployee.Text == "" || maskedTextBoxDateBirth.Text == "" || textBoxPosition.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Заполните все поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                      RefreshDataGrid(dataGridViewEmployee);
                  }
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
                RefreshDataGrid(dataGridViewEmployee);
            }
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployee.Rows[selectedRow];
                textBoxIdEmployee.Text = row.Cells[0].Value.ToString();
                textBoxFioEmployee.Text = row.Cells[1].Value.ToString();
                maskedTextBoxDateBirth.Text = row.Cells[2].Value.ToString();
                textBoxPosition.Text = row.Cells[3].Value.ToString();
                textBoxAddress.Text = row.Cells[4].Value.ToString();

            }
        }

        private void textBoxFioEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsWhiteSpace(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsControl(e.KeyChar)) == false)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxDateBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsWhiteSpace(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsControl(e.KeyChar)) == false)
            {
                e.Handled = true;
            }
        }
    }
}
