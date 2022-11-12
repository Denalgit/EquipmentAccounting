using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormEquipDirectory : Form
    {
        DataBase database = new DataBase();

        int selectedRow;

        public FormEquipDirectory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxIdNameEquip.ReadOnly = true;

        }

        private void CreateColumns()
        {
            dataGridViewEquipDirectory.Columns.Add("IdNameEquip", "Код названия оборудования");
            dataGridViewEquipDirectory.Columns.Add("EquipName", "Название оборудования");
            dataGridViewEquipDirectory.Columns.Add("Price", "Цена");
            dataGridViewEquipDirectory.Columns.Add("Weight", "Масса");
            dataGridViewEquipDirectory.Columns.Add("IsNew", String.Empty);
        }
        
        private void ClearFields()
        {
            textBoxIdNameEquip.Text = "";
            textBoxEquipName.Text = "";
            numericUpDownPrice.Text = "";
            textBoxWeight.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM EquipDirectory";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewEquipDirectory.Columns[4].Visible = false;
            database.closeConnection();
        }

        private void FormEquipDirectory_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewEquipDirectory);
            
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertEquipDirectory InsertEquipDirectory = new FormInsertEquipDirectory();
            InsertEquipDirectory.ShowDialog();
            RefreshDataGrid(dataGridViewEquipDirectory);
        }
        
        private void deleteRow()
        {
            int index = dataGridViewEquipDirectory.CurrentCell.RowIndex;

            dataGridViewEquipDirectory.Rows[index].Visible = false;

            if(dataGridViewEquipDirectory.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewEquipDirectory.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridViewEquipDirectory.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private new void Update()
        {
            database.openConnection();

            for(int index = 0; index < dataGridViewEquipDirectory.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewEquipDirectory.Rows[index].Cells[4].Value;
                if (rowState == RowState.Eixsted)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var IdNameEquip = Convert.ToInt32(dataGridViewEquipDirectory.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM EquipDirectory WHERE IdNameEquip = {IdNameEquip}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();        
                }

                if (rowState == RowState.Modified)
                {
                    var IdNameEquip = dataGridViewEquipDirectory.Rows[index].Cells[0].Value.ToString();
                    var EquipName = dataGridViewEquipDirectory.Rows[index].Cells[1].Value.ToString();
                    var Price = dataGridViewEquipDirectory.Rows[index].Cells[2].Value.ToString();
                    var Weight = dataGridViewEquipDirectory.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"UPDATE EquipDirectory SET EquipName = '{EquipName}', Price = '{Price}', Weight = '{Weight}' WHERE IdNameEquip = '{IdNameEquip}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
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
                RefreshDataGrid(dataGridViewEquipDirectory);
            }
        }

        private void dataGridViewEquipDirectory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEquipDirectory.Rows[selectedRow];
                textBoxIdNameEquip.Text = row.Cells[0].Value.ToString();
                textBoxEquipName.Text = row.Cells[1].Value.ToString();
                numericUpDownPrice.Text = row.Cells[2].Value.ToString();
                textBoxWeight.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewEquipDirectory.CurrentCell.RowIndex;

            var IdNameEquip = textBoxIdNameEquip.Text;
            var EquipName = textBoxEquipName.Text;
            int Price;
            var Weight = textBoxWeight.Text; ; 

            if(dataGridViewEquipDirectory.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(numericUpDownPrice.Text, out Price))
                {
                    dataGridViewEquipDirectory.Rows[selectedRowIndex].SetValues(IdNameEquip, EquipName, Price, Weight);
                    dataGridViewEquipDirectory.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Запись не удалось изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                RefreshDataGrid(dataGridViewEquipDirectory);
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void UpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpSortPrice(dataGridViewEquipDirectory);

        }

        private void UpSortPrice (DataGridView dgw)
        {
            dgw.Rows.Clear();

            string sortUp = $"EXEC PriceSortUp";
            SqlCommand command = new SqlCommand(sortUp, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewEquipDirectory.Columns[4].Visible = false;
            database.closeConnection();
        }

        private void DownSortPrice(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string sortUp = $"EXEC PriceSortDown";
            SqlCommand command = new SqlCommand(sortUp, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewEquipDirectory.Columns[4].Visible = false;
            database.closeConnection();
        }

        private void CanselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewEquipDirectory);
        }

        private void DownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownSortPrice(dataGridViewEquipDirectory); 
        }

        private void numericUpDownPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
