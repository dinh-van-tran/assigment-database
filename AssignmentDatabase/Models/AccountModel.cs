using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AssignmentDatabase.Models
{
    public partial class AccountModel
    {
        public bool CheckUserExists(string username, string password)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "';");

            bool foundUser = reader.HasRows;
            connection.Close();

            return foundUser;
        }
        //lay data lên table 
        public List<Account> GetAlltableAccount()
        {
            Connection conn = new Connection() ;
            SqlDataReader reader = conn.ExcuteQuery( "SELECT * FROM Account;"); 
            List<Account> result = new List<Account>();
            while(reader.Read())
            {
                Account account = new Account();
                account.Username = reader["Username"].ToString();
                account.Name = reader["Name"].ToString();
                account.Password = reader["Password"].ToString();
                account.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                account.UpdatedDate = DateTime.Parse(reader["UpdatedDate"].ToString());

                result.Add(account);
            }
            conn.Close();
            return result;
        }
        //end get data

        public static bool checkkey(string checkUsername)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT TOP 1 * FROM Account WHERE Username = '" + checkUsername + "';");

            bool foundUser = reader.HasRows;
            connection.Close();

            return foundUser;

        }
        //tem tài khoan 
        public void Addaccount(string username, string name, string password)
        {
            Connection connection = new Connection();
            connection.ExcuteQuery("INSERT INTO Account(Username, Name, Password) VALUES ('" + username + "', N'" + name + "', N'" + password + "')");
            //connection.ExcuteQuery("INSERT INTO DeviceType(Code, Name, Description) VALUES ('" + username + "', N'" + name + "', N'" + password + "')");
            connection.Close();
        }

        ///update data
        public void Updateaccount(string username, string name, string password)
        {
            Connection connection = new Connection();
            connection.ExcuteQuery("UPDATE Account SET Name = '" + name + "', Password = '" + password + "' WHERE Username = '" + username + "'");
           
            //connection.ExcuteQuery("INSERT INTO DeviceType(Code, Name, Description) VALUES ('" + username + "', N'" + name + "', N'" + password + "')");
            connection.Close();
        }
        //del account
        public void Deleteaccount(string username)
        {
            Connection connection = new Connection();
            connection.ExcuteQuery("DELETE FROM Account  WHERE Username = '" + username + "'");

            //connection.ExcuteQuery("INSERT INTO DeviceType(Code, Name, Description) VALUES ('" + username + "', N'" + name + "', N'" + password + "')");
            connection.Close();
        }


    }
}
