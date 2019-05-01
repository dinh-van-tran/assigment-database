using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabase.Models
{
    public class AccountModel
    {
        public bool CheckUserExists(string username, string password)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "';");

            bool foundUser = reader.HasRows;
            connection.Close();

            return foundUser;
        }
    }
}
