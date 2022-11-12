using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertProvider : Form
    {
        DataBase database = new DataBase();

        public FormInsertProvider()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var CompanyName = textBoxCompanyName.Text;
            var CompanyPhone = maskedTextBoxCompanyPhone.Text;
            var FioRepresent = textBoxFioRepresent.Text;

            var addQuery = $"INSERT INTO [Provider] (CompanyName, CompanyPhone, FioRepresent) VALUES ('{CompanyName}', '{CompanyPhone}', '{FioRepresent}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
           
            
            database.closeConnection();
            this.Close();
        }



        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
