using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabase
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "';");

            bool foundUser = reader.HasRows;
            connection.Close();

            if (!foundUser)
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login Sucess", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


        }
    }
}
