using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormBalance : Form
    {
        private DataBase database = new DataBase();

        public FormBalance()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Создание столбцов таблицы
        private void CreateColumns()
        {
            dataGridViewBalance.Columns.Add("IdBalance", "Код остатка");
            dataGridViewBalance.Columns.Add("IdEquipment", "Код оборудования");
            dataGridViewBalance.Columns.Add("Quantity", "Количество");
            dataGridViewBalance.Columns.Add("BalanceFixationDate", "Дата фиксации остатка");
            dataGridViewBalance.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Balance";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataGridViewBalance.Columns[4].Visible = false;
            database.closeConnection();
        }

        private void toolStripButtonExite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBalance_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewBalance);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var BalanceDate = maskedTextBoxBalanceDate.Text;
            string searchString = $"SELECT * FROM Balance WHERE BalanceFixationDate =  ('{BalanceDate}')";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }
       

        private void toolStripButtonRebut_Click(object sender, EventArgs e)
        {
            maskedTextBoxBalanceDate.Text = "";
            RefreshDataGrid(dataGridViewBalance);
        }

        private void toolStripLabelBalance_Click(object sender, EventArgs e)
        {
            Search(dataGridViewBalance);
        }
    }
}
