using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertEquipDirectory : Form
    {
        DataBase database = new DataBase();

        public FormInsertEquipDirectory()
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

            var EquipName = textBoxEquipName.Text;
            int Price;
            var Weight = textBoxWeight.Text;

            if (int.TryParse(textBoxPrice.Text, out Price))
            {
                var addQuery = $"INSERT INTO [EquipDirectory] (EquipName, Price, Weight) VALUES ('{EquipName}', '{Price}', '{Weight}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
            }
       
            else
            {
                MessageBox.Show("Запись не удалось создать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
            this.Close();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
