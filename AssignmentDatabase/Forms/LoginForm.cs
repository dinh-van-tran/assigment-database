using AssignmentDatabase.Forms;
using AssignmentDatabase.Models;
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
            //checking username
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông Báo");
                usernameTextBox.Focus();
                return;
                
            }
            //checking password 
            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu","Thông Báo");
                passwordTextBox.Focus();
                return;
            }

            AccountModel accountModel = new AccountModel();
            if (!accountModel.CheckUserExists(username, password)) {
                MessageBox.Show("Sai thông tin tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //checking username and password empty 
                   
           ActionForm actionForm = new ActionForm();
            actionForm.ShowDialog();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn Có muốn thoát không ?", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                usernameTextBox.Focus();
        }
    }
}
