using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertOrder : Form
    {
        DataBase database = new DataBase();

        public FormInsertOrder()
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

            int IdProvider;
            int IdEmployee;
            int IdEquipment;
            int Quantity;
            int Value;
            var OrderDate = maskedTextBoxOrderDate.Text;

            if (int.TryParse(comboBoxProvider.Text, out IdProvider) && (int.TryParse(comboBoxEmployee.Text, out IdEmployee)) && (int.TryParse(comboBoxEquipment.Text, out IdEquipment)) && (int.TryParse(textBoxValue.Text, out Value)) && (int.TryParse(textBoxQuantity.Text, out Quantity)))
            {
                var addQuery = $"INSERT INTO [Coming] (IdProvider, IdEmployee, IdEquipment, Quantity, Value, OrderDate) VALUES ('{IdProvider}', '{IdEmployee}', '{IdEquipment}', '{Value}', '{Quantity}', '{OrderDate}')";

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

        private void FormInsertOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Provider);

        }

        private void maskedTextBoxOrderDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
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
