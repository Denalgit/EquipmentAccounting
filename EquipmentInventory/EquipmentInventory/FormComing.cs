using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormComing : Form
    {
        private DataBase database = new DataBase();

        int selectedRow;

        public FormComing()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridViewComing.Columns.Add("IdComing", "Код прихода");
            dataGridViewComing.Columns.Add("IdOrder", "Код заказа");
            dataGridViewComing.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewComing.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewComing.Columns.Add("InvoiseNumber", "Номер накладной");
            dataGridViewComing.Columns.Add("Quantity", "Количество");
            dataGridViewComing.Columns.Add("DeliveryDate", "Дата прихода");
            dataGridViewComing.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxIdComing.Text = "";
            textBoxIdOrder.Text = "";
            textBoxIdEmployee.Text = "";
            textBoxIdEquipment.Text = "";
            textBoxInvoiseNumber.Text = "";
            textBoxQuantity.Text = "";
            maskedTextBoxDeliveryDate.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Coming";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewComing.Columns[7].Visible = false;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormComing_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewComing);
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewComing.Rows[selectedRow];
                textBoxIdComing.Text = row.Cells[0].Value.ToString();
                textBoxIdOrder.Text = row.Cells[1].Value.ToString();
                textBoxIdEmployee.Text = row.Cells[2].Value.ToString();
                textBoxIdEquipment.Text = row.Cells[3].Value.ToString();
                textBoxInvoiseNumber.Text = row.Cells[4].Value.ToString();
                textBoxQuantity.Text = row.Cells[5].Value.ToString();
                maskedTextBoxDeliveryDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewComing.CurrentCell.RowIndex;

            var IdComing = textBoxIdComing.Text;
            var IdOrder = textBoxIdOrder.Text;
            var IdEmployee = textBoxIdEmployee.Text;
            var IdEquipment = textBoxIdEquipment.Text;
            var InvoiseNumber = textBoxInvoiseNumber.Text;
            var Quantity = textBoxQuantity.Text;
            var DeliveryDate = maskedTextBoxDeliveryDate.Text; ;

            if (dataGridViewComing.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                    dataGridViewComing.Rows[selectedRowIndex].SetValues(IdComing, IdOrder, IdEmployee, IdEquipment, InvoiseNumber, Quantity, DeliveryDate);
                    dataGridViewComing.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
            }
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewComing.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewComing.Rows[index].Cells[7].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var IdComing = Convert.ToInt32(dataGridViewComing.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Coming WHERE IdComing = {IdComing}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var IdComing = dataGridViewComing.Rows[index].Cells[0].Value.ToString();
                    var InvoiseNumber = dataGridViewComing.Rows[index].Cells[4].Value.ToString();
                    var Quantity = dataGridViewComing.Rows[index].Cells[5].Value.ToString();
                    var ComingDate = dataGridViewComing.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"UPDATE Coming SET InvoiseNumber = '{InvoiseNumber}', Quantity = '{Quantity}', ComingDate = '{ComingDate}' WHERE IdComing = '{IdComing}'";
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
                RefreshDataGrid(dataGridViewComing);
            }
        }

        private void deleteRow()
        {
            int index = dataGridViewComing.CurrentCell.RowIndex;

            dataGridViewComing.Rows[index].Visible = false;

            if (dataGridViewComing.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewComing.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridViewComing.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись о приходе?",
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
                RefreshDataGrid(dataGridViewComing);
            }

            }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertComing ComingIns = new FormInsertComing();
            ComingIns.ShowDialog();
            RefreshDataGrid(dataGridViewComing);
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxInvoiseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
