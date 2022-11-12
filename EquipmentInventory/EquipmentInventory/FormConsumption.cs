using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormConsumption : Form
    {
        private DataBase database = new DataBase();

        int selectedRow;

        public FormConsumption()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridViewConsumption.Columns.Add("IdConsumption", "Код прихода");
            dataGridViewConsumption.Columns.Add("IdApplication", "Код заказа");
            dataGridViewConsumption.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewConsumption.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewConsumption.Columns.Add("Quantity", "Количество");
            dataGridViewConsumption.Columns.Add("ConsumptionDate", "Дата прихода");
            dataGridViewConsumption.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdConsumption.Text = "";
            textBoxIdApplication.Text = "";
            textBoxIdEmployee.Text = "";
            textBoxIdEquipment.Text = "";
            textBoxQuantity.Text = "";
            maskedTextBoxConsumptionDate.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Consumption";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewConsumption.Columns[6].Visible = false;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsumption_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewConsumption);
        }

        private void dataGridViewComing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewConsumption.Rows[selectedRow];
                textBoxIdConsumption.Text = row.Cells[0].Value.ToString();
                textBoxIdApplication.Text = row.Cells[1].Value.ToString();
                textBoxIdEmployee.Text = row.Cells[2].Value.ToString();
                textBoxIdEquipment.Text = row.Cells[3].Value.ToString();
                textBoxQuantity.Text = row.Cells[4].Value.ToString();
                maskedTextBoxConsumptionDate.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewConsumption.CurrentCell.RowIndex;

            var IdConsumption = textBoxIdConsumption.Text;
            var IdApplication = textBoxIdApplication.Text;
            var IdEmployee = textBoxIdEmployee.Text;
            var IdEquipment = textBoxIdEquipment.Text;
            var Quantity = textBoxQuantity.Text;
            var ConsumptionDate = maskedTextBoxConsumptionDate.Text; ;

            if (dataGridViewConsumption.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewConsumption.Rows[selectedRowIndex].SetValues(IdConsumption, IdApplication, IdEmployee, IdEquipment, Quantity, ConsumptionDate);
                dataGridViewConsumption.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
            }
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewConsumption.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewConsumption.Rows[index].Cells[6].Value;
                if (rowState == RowState.Eixsted)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var IdConsumption = Convert.ToInt32(dataGridViewConsumption.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Consumption WHERE IdConsumption = {IdConsumption}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdConsumption = dataGridViewConsumption.Rows[index].Cells[0].Value.ToString();
                    var Quantity = dataGridViewConsumption.Rows[index].Cells[4].Value.ToString();
                    var ConsumptionDate = dataGridViewConsumption.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE Consumption SET Quantity = '{Quantity}', ConsumptionDate = '{ConsumptionDate}' WHERE IdConsumption = '{IdConsumption}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxIdApplication.Text == "" || textBoxIdConsumption.Text == "" || textBoxIdEmployee.Text == "" || textBoxIdEquipment.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Заполните все поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                        RefreshDataGrid(dataGridViewConsumption);
                    }
            }
        }

        private void deleteRow()
        {
            int index = dataGridViewConsumption.CurrentCell.RowIndex;

            dataGridViewConsumption.Rows[index].Visible = false;

            if (dataGridViewConsumption.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewConsumption.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridViewConsumption.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись о расходе?",
                       "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
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
                RefreshDataGrid(dataGridViewConsumption);
            }
           }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertConsumption ConsumptionIns = new FormInsertConsumption();
            ConsumptionIns.ShowDialog();
            RefreshDataGrid(dataGridViewConsumption);
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
