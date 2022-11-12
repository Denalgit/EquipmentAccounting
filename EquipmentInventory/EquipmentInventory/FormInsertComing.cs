using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertComing : Form
    {
        DataBase database = new DataBase();

        public FormInsertComing()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormInsertComing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Order);

        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            database.openConnection();

            int IdOrder;
            int IdEmployee;
            int IdEquipment;
            int InvoiseNumber;
            int Quantity;
            var DeliveryDate = maskedTextBoxDeliveryDate.Text;

            if (int.TryParse(comboBoxOrder.Text, out IdOrder) && (int.TryParse(comboBoxEmployee.Text, out IdEmployee)) && (int.TryParse(comboBoxEquipment.Text, out IdEquipment)) && (int.TryParse(textBoxInvoiseNumber.Text, out InvoiseNumber)) && (int.TryParse(textBoxQuantity.Text, out Quantity)))
            {
                var addQuery = $"INSERT INTO [Coming] (IdOrder, IdEmployee, IdEquipment, InvoiseNumber, Quantity, DeliveryDate) VALUES ('{IdOrder}', '{IdEmployee}', '{IdEquipment}', '{InvoiseNumber}', '{Quantity}', '{DeliveryDate}')";

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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInvoiseNumber_KeyPress(object sender, KeyPressEventArgs e)
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
