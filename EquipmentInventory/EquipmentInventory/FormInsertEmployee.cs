using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertEmployee : Form
    {
        DataBase database = new DataBase();

        public FormInsertEmployee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var FioEmployee = textBoxFioEmployee.Text;
            var DateBirth = maskedTextBoxDateBirth.Text;
            var Position = textBoxPosition.Text;
            var Address = textBoxAddress.Text;

            var addQuery = $"INSERT INTO [Employee] (FioEmployee, DateBirth, Position, Address) VALUES ('{FioEmployee}', '{DateBirth}', '{Position}', '{Address}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
            this.Close();
        }

        private void textBoxFioEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsWhiteSpace(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsControl(e.KeyChar)) == false)
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

        private void maskedTextBoxDateBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
