using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormWriteOff : Form
    {
        private DataBase database = new DataBase();

        int selectedRow;

        public FormWriteOff()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridViewWriteOff.Columns.Add("IdWriteOff", "Код списания");
            dataGridViewWriteOff.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewWriteOff.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewWriteOff.Columns.Add("Quantity", "Количество");
            dataGridViewWriteOff.Columns.Add("WriteOffDate", "Дата списания");
            dataGridViewWriteOff.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdWriteOff.Text = "";
            textBoxIdEmployee.Text = "";
            textBoxIdEquipment.Text = "";
            textBoxQuantity.Text = "";
            maskedTextBoxWriteOffDate.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM WriteOff";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewWriteOff.Columns[5].Visible = false;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormWriteOff_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewWriteOff);
        }

        private void dataGridViewConsumption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewWriteOff.Rows[selectedRow];
                textBoxIdWriteOff.Text = row.Cells[0].Value.ToString();
                textBoxIdEmployee.Text = row.Cells[1].Value.ToString();
                textBoxIdEquipment.Text = row.Cells[2].Value.ToString();
                textBoxQuantity.Text = row.Cells[3].Value.ToString();
                maskedTextBoxWriteOffDate.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewWriteOff.CurrentCell.RowIndex;

            var IdWriteOff = textBoxIdWriteOff.Text;
            var IdEmployee = textBoxIdEmployee.Text;
            var IdEquipment = textBoxIdEquipment.Text;
            var Quantity = textBoxQuantity.Text;
            var WriteOffDate = maskedTextBoxWriteOffDate.Text; ;

            if (dataGridViewWriteOff.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewWriteOff.Rows[selectedRowIndex].SetValues(IdWriteOff, IdEmployee, IdEquipment, Quantity, WriteOffDate);
                dataGridViewWriteOff.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewWriteOff.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewWriteOff.Rows[index].Cells[5].Value;
                if (rowState == RowState.Eixsted)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var IdWriteOff = Convert.ToInt32(dataGridViewWriteOff.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM WriteOff WHERE IdWriteOff = {IdWriteOff}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdWriteOff = dataGridViewWriteOff.Rows[index].Cells[0].Value.ToString();
                    var Quantity = dataGridViewWriteOff.Rows[index].Cells[4].Value.ToString();
                    var WriteOffDate = dataGridViewWriteOff.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE WriteOff SET Quantity = '{Quantity}', WriteOffDate = '{WriteOffDate}' WHERE IdWriteOff = '{IdWriteOff}'";
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
                RefreshDataGrid(dataGridViewWriteOff);
            }
        }

        private void deleteRow()
        {
            int index = dataGridViewWriteOff.CurrentCell.RowIndex;

            dataGridViewWriteOff.Rows[index].Visible = false;

            if (dataGridViewWriteOff.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewWriteOff.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridViewWriteOff.Rows[index].Cells[5].Value = RowState.Deleted;
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
                RefreshDataGrid(dataGridViewWriteOff);
            }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertWriteOff InsertWriteOff = new FormInsertWriteOff();
            InsertWriteOff.ShowDialog();
            RefreshDataGrid(dataGridViewWriteOff);
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
