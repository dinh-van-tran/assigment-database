using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AssignmentDatabase
{
    class Connection
    {
        public static string ConnectionString = "Data Source=localhost;Initial Catalog=Assigment;Integrated Security=True";

        private SqlConnection connection;

        public void Open()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public SqlDataReader ExcuteQuery(string query)
        {
            Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
      
          
        public  DataTable GetDataToTable(string sql)
        {
            Open();
            SqlDataAdapter MyData = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            MyData.SelectCommand = new SqlCommand();
           
            MyData.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
      


    }
}
