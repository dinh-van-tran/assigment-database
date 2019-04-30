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
        public static string ConnectionString = "Data Source=localhost;Initial Catalog=Assigment;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "';", connection);
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Login Sucess", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
