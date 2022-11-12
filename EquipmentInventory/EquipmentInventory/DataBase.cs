using System.Data.SqlClient;

namespace EquipmentInventory
{
    class DataBase
    {
        SqlConnection sqlConnection= new SqlConnection(@"Data Source = DESKTOP-L1MVM4Q; Initial Catalog = EQUIPMENT_ACCOUNTING; Integrated Security = True");
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
