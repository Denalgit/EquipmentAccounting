using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertDepartment : Form
    {
        DataBase database = new DataBase();

        public FormInsertDepartment()
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

            var DepartNumber = textBoxDepartNumber.Text;
            var DepartmentPhone = maskedTextBoxDepartmentPhone.Text;

            var addQuery = $"INSERT INTO [Department] (DepartNumber, DepartmentPhone) VALUES ('{DepartNumber}', '{DepartmentPhone}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();


            database.closeConnection();
            this.Close();
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
