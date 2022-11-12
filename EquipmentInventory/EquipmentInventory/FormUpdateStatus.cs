using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormUpdateStatus : Form
    {
        private DataBase database = new DataBase();

        public FormUpdateStatus()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridViewStatus.Columns.Add("IdApplication", "Код заявки");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Статус выполнения";
            dataGridViewStatus.Columns.Add(checkColumn);
        }

        private void ReadSingleRow(IDataRecord record)
        {
            dataGridViewStatus.Rows.Add(record.GetInt32(0), record.GetBoolean(1));
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid()
        {
            dataGridViewStatus.Rows.Clear();

            string queryString = $"SELECT IdApplication, ExecutionStatus FROM Application";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();

            database.closeConnection();
        }

        private void toolStripButtonExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateStatus_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewStatus.Rows.Count; index++)
            {
                var IdApplication = dataGridViewStatus.Rows[index].Cells[0].Value.ToString();
                var ExecutionStatus = dataGridViewStatus.Rows[index].Cells[1].Value.ToString();

                var changeQuery = $"UPDATE Application SET ExecutionStatus = '{ExecutionStatus}' WHERE IdApplication = '{IdApplication}'";

                var command = new SqlCommand(changeQuery, database.getConnection());

                command.ExecuteNonQuery();
            }

            database.closeConnection();

            RefreshDataGrid();
        }
    }
}
