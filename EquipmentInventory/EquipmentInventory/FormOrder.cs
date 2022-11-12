using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormOrder : Form
    {
        private DataBase database = new DataBase();

        int selectedRow;

        public FormOrder()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridViewOrder.Columns.Add("IdOrder", "Код заказа");
            dataGridViewOrder.Columns.Add("IdProvider", "Код поставщика");
            dataGridViewOrder.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewOrder.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewOrder.Columns.Add("Quantity", "Количество");
            dataGridViewOrder.Columns.Add("Value", "Стоимость");
            dataGridViewOrder.Columns.Add("OrderDate", "Дата заказа");
            dataGridViewOrder.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdOrder.Text = "";
            textBoxIdProvider.Text = "";
            textBoxIdEmployee.Text = "";
            textBoxIdEquipment.Text = "";
            textBoxQuantity.Text = "";
            numericUpDownValue.Text = "";
            maskedTextBoxOrderDate.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM [Order]";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewOrder.Columns[7].Visible = false;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewOrder);
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[selectedRow];
                textBoxIdOrder.Text = row.Cells[0].Value.ToString();
                textBoxIdProvider.Text = row.Cells[1].Value.ToString();
                textBoxIdEmployee.Text = row.Cells[2].Value.ToString();
                textBoxIdEquipment.Text = row.Cells[3].Value.ToString();
                textBoxQuantity.Text = row.Cells[4].Value.ToString();
                numericUpDownValue.Text = row.Cells[5].Value.ToString();
                maskedTextBoxOrderDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewOrder.CurrentCell.RowIndex;

            var IdOrder = textBoxIdOrder.Text;
            var IdProvider = textBoxIdProvider.Text;
            var IdEmployee = textBoxIdEmployee.Text;
            var IdEquipment = textBoxIdEquipment.Text;
            var Quantity = textBoxQuantity.Text;
            int Value;
            var OrderDate = maskedTextBoxOrderDate.Text; ;

            if (dataGridViewOrder.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(numericUpDownValue.Text, out Value))
                {
                    dataGridViewOrder.Rows[selectedRowIndex].SetValues(IdOrder, IdProvider, IdEmployee, IdEquipment, Quantity, Value, OrderDate);
                    dataGridViewOrder.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Запись не удалось изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewOrder.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewOrder.Rows[index].Cells[7].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var Order = Convert.ToInt32(dataGridViewOrder.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM [Order] WHERE [Order] = {Order}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdOrder = dataGridViewOrder.Rows[index].Cells[0].Value.ToString();
                    var Quantity = dataGridViewOrder.Rows[index].Cells[4].Value.ToString();
                    var Value = dataGridViewOrder.Rows[index].Cells[5].Value.ToString();
                    var OrderDate = dataGridViewOrder.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"UPDATE [Order] SET Quantity = '{Quantity}', Value = '{Value}', OrderDate = '{OrderDate}' WHERE IdOrder = '{IdOrder}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
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
                RefreshDataGrid(dataGridViewOrder);
            }
        }

        private void deleteRow()
        {
            int index = dataGridViewOrder.CurrentCell.RowIndex;

            dataGridViewOrder.Rows[index].Visible = false;

            if (dataGridViewOrder.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewOrder.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridViewOrder.Rows[index].Cells[7].Value = RowState.Deleted;
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
                RefreshDataGrid(dataGridViewOrder);
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxOrderDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertOrder OrderIns = new FormInsertOrder();
            OrderIns.ShowDialog();
            RefreshDataGrid(dataGridViewOrder);
        }

        private void numericUpDownValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
