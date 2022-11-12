using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormInsertWriteOff : Form
    {
        DataBase database = new DataBase();

        public FormInsertWriteOff()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormInsertWriteOff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.EquipDirectory". При необходимости она может быть перемещена или удалена.
            this.equipDirectoryTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.EquipDirectory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUIPMENT_ACCOUNTINGDataSet.WriteOff". При необходимости она может быть перемещена или удалена.
            this.writeOffTableAdapter.Fill(this.eQUIPMENT_ACCOUNTINGDataSet.WriteOff);

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.equipmentTableAdapter.FillBy1(this.eQUIPMENT_ACCOUNTINGDataSet.Equipment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var IdEmployee = comboBoxEmployee.Text;
            var IdEquipment = comboBoxEquipment.Text;
            var Quantity = textBoxQuantity.Text;
            var WriteOffDate = maskedTextBoxWriteOffDate.Text;
   
            var addQuery = $"INSERT INTO [WriteOff] (IdEmployee, IdEquipment, Quantity, WriteOffDate) VALUES ('{IdEmployee}', '{IdEquipment}', '{Quantity}', '{WriteOffDate}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

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

        private void maskedTextBoxWriteOffDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
