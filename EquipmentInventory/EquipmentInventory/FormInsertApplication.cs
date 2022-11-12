using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertApplication : Form
    {
        DataBase database = new DataBase();

        public FormInsertApplication()
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

            int IdDepartment;
            int IdEmployee;
            int IdEquipment;
            int Quantity;
            var ApplicationDate = maskedTextBoxApplicationDate.Text;

            if (int.TryParse(comboBoxDepartment.Text, out IdDepartment) && (int.TryParse(comboBoxEmployee.Text, out IdEmployee)) && (int.TryParse(comboBoxEquipment.Text, out IdEquipment))  && (int.TryParse(textBoxQuantity.Text, out Quantity)))
            {
                var addQuery = $"INSERT INTO [Application] (IdDepartment, IdEmployee, IdEquipment, Quantity, ApplicationDate) VALUES ('{IdDepartment}', '{IdEmployee}', '{IdEquipment}', '{Quantity}', '{ApplicationDate}')";

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

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
