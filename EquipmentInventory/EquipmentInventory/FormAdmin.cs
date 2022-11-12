using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class FormAdmin : Form
    {
       private DataBase database = new DataBase();

        public FormAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Создание столбцов таблицы
        private void CreateColumns()
        {
            dataGridViewAdmin.Columns.Add("IdUser", "Код пользователя");
            dataGridViewAdmin.Columns.Add("LoginUser", "Логин");
            dataGridViewAdmin.Columns.Add("PasswordUser", "Пароль");

            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Статус администратора";
            dataGridViewAdmin.Columns.Add(checkColumn);
        }

        private void ReadSingleRow(IDataRecord record)
        {
            dataGridViewAdmin.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),  record.GetBoolean(3));
        }

        //Обновление содержимого таблицы
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM UserAccount";
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
            Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewAdmin);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            database.openConnection();
            
            for (int index = 0; index < dataGridViewAdmin.Rows.Count; index++)
            {
                var IdUser = dataGridViewAdmin.Rows[index].Cells[0].Value.ToString();
                var LoginUser = dataGridViewAdmin.Rows[index].Cells[1].Value.ToString();
                var PasswordUser = dataGridViewAdmin.Rows[index].Cells[2].Value.ToString();
                var IsAdmin = dataGridViewAdmin.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"UPDATE UserAccount SET IsAdmin = '{IsAdmin}', LoginUser = '{LoginUser}', PasswordUser = '{PasswordUser}' WHERE IdUser = '{IdUser}'";

                var command = new SqlCommand(changeQuery, database.getConnection());

                command.ExecuteNonQuery();
            }

            database.closeConnection();

            RefreshDataGrid(dataGridViewAdmin);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIndex = dataGridViewAdmin.CurrentCell.RowIndex;

            var IdUser = Convert.ToInt32(dataGridViewAdmin.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"DELETE FROM UserAccount WHERE IdUser = '{IdUser}'";
            var command = new SqlCommand(deleteQuery, database.getConnection());

            command.ExecuteNonQuery();

            database.closeConnection();

            RefreshDataGrid(dataGridViewAdmin);
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertAdmin AdminIns = new FormInsertAdmin();
            AdminIns.ShowDialog();
            RefreshDataGrid(dataGridViewAdmin);
        }
    }
}
