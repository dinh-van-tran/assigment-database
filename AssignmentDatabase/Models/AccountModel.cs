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
        DataClassesDataContext db = new DataClassesDataContext();

        public bool CheckUserExists(string username, string password)
        {
            if (db.Accounts.Any(account => account.Username == username && account.Password == password))
            {
                return true;
            }

            return false;
        }

        public List<Account> GetAll()
        {
            var accountQuery = from accounts in db.Accounts
                                  select accounts;

            List<Account> result = new List<Account>();
            foreach (var account in accountQuery)
            {
                result.Add(account);
            }

            return result;
        }

        public static bool CheckKey(string username)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT TOP 1 * FROM Account WHERE Username = '" + username + "';");

            bool foundUser = reader.HasRows;
            connection.Close();

            return foundUser;

        }

        public void AddAccount(string username, string name, string password)
        {
            Account account = new Account();
            account.Username = username;
            account.Name = name;
            account.Password = password;

            db.Accounts.InsertOnSubmit(account);
            db.SubmitChanges();
        }

        public void UpdateAccount(string username, string name, string password)
        {
            var row = db.Accounts.First(account => account.Username == username && account.Password == password);
            if (row == null)
            {
                return;
            }

            row.Name = name;
            db.SubmitChanges();
        }

        public void DeleteAccount(string username)
        {
            var rows = from account in db.Accounts
                       where account.Username == username
                      select account;

            foreach(var row in rows)
            {
                db.Accounts.DeleteOnSubmit(row);
            }
        }
    }
}
