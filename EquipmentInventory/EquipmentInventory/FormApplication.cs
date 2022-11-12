using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    
    public partial class FormApplication : Form
    {
        DataBase database = new DataBase();

        public FormApplication()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void CreateColumns()
        {
            dataGridViewApplication.Columns.Add("IdApplication", "Код заявки");
            dataGridViewApplication.Columns.Add("IdDepartment", "Код отдела");
            dataGridViewApplication.Columns.Add("IdEmployee", "Код сотрудника");
            dataGridViewApplication.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewApplication.Columns.Add("Quantity", "Количество");
            dataGridViewApplication.Columns.Add("ApplicationDate", "Дата поступления заявки");
            dataGridViewApplication.Columns.Add("ExecutionStatus", "Статус выполнения");
            dataGridViewApplication.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5),
                record.GetBoolean(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Application";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewApplication.Columns[7].Visible = false;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewApplication);
        }

        private void dataGridViewApplication_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Выполнена" : "Не выполнена";
                    e.FormattingApplied = true;
                }
            }
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertApplication ApplicationIns = new FormInsertApplication();
            ApplicationIns.ShowDialog();
            RefreshDataGrid(dataGridViewApplication);
        }

        private new void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewApplication.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewApplication.Rows[index].Cells[7].Value;
                if (rowState == RowState.Eixsted)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var IdApplication = Convert.ToInt32(dataGridViewApplication.Rows[index].Cells[0].Value);

                    var deleteQuery = $"DELETE FROM Application WHERE IdApplication = {IdApplication}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void deleteRow()
        {
            int index = dataGridViewApplication.CurrentCell.RowIndex;

            dataGridViewApplication.Rows[index].Visible = false;

            if (dataGridViewApplication.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewApplication.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridViewApplication.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteRow();
                Update();
            }
            catch (SqlException)
            {
                MessageBox.Show("Не удалось удалить запись!", "Запись не удалена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDataGrid(dataGridViewApplication);
            }
        }

        private void toolStripButtonStatus_Click(object sender, EventArgs e)
        {
            FormUpdateStatus StatusUpd = new FormUpdateStatus();
            StatusUpd.ShowDialog();
            RefreshDataGrid(dataGridViewApplication);
        }
    }
}
