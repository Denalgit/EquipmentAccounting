using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertAdmin : Form
    {
        DataBase database = new DataBase();

        public FormInsertAdmin()
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

            var LoginUser = textBoxLogin.Text;
            var PasswordUser = md5.hashPassword(textBoxPassword.Text);

            var addQuery = $"INSERT INTO [UserAccount] (LoginUser, PasswordUser) VALUES ('{LoginUser}', '{PasswordUser}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            
            database.closeConnection();
            this.Close();
        }
    }
}
