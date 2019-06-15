using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AssignmentDatabase.Models;
using System.IO;

namespace AssignmentDatabase.Forms
{
    public partial class AccountForm : Form
    {
        BindingSource bindingSouce = new BindingSource();
        private AccountModel accountModel = new AccountModel();
        int Indexrow;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assigmentDataSet.Account' table. You can move, or remove it, as needed.
            
            LoadAccontToGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadAccontToGridView()
        {
            List<Account> account = new List<Account>();
            account = accountModel.GetAllAccounts();
            bindingSouce.DataSource = account;
            dataGridView_Account.DataSource = bindingSouce;
         
            
        }
        public void resetGridview()
        {
            List<Account> account = new List<Account>();
            account = accountModel.GetAllAccounts();
            bindingSouce.DataSource = account;
        }
       //thêm nhan viên mới
        public void addAccount()
        {
            //khai bao biên cho textbox
            string Username = txtUserName.Text.Trim();
            string name = txtName.Text.Trim();
            string password = txtPassWord.Text.Trim();


            if (txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải Nhập Tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            //check name 

            if (txtName.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn phải Nhập Tên Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            //Check Password 
            if(txtPassWord.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn phải nhập mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            //check tai khoan tồn tại
            if (AccountModel.CheckKey(Username))
            {
                MessageBox.Show("Tài Khoản Đấ Có vui lòng chọn tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            accountModel.AddAccount(Username, name, password);
            MessageBox.Show("Thêm nhân viên thành công ","Thông báo");
            txtUserName.Text = "" ;
            txtName.Text = "" ;
            txtPassWord.Text = "";
            txtUserName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addAccount();
            resetGridview();
          
        }

        private void dataGridView_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Indexrow = e.RowIndex;

                DataGridViewRow row = dataGridView_Account.Rows[Indexrow];

                txtUserName.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPassWord.Text = row.Cells[2].Value.ToString();
            }
        }
        //Sữa Nhân Viên
        public void EditAccount()
        {
            string Username = txtUserName.Text.Trim();
            string name = txtName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            accountModel.UpdateAccount(Username, name, password);
            MessageBox.Show("Sữa Thành Công ", "Thông Báo");
        }

        public void DeleteAccount()
        {
            string Username = txtUserName.Text.Trim();
            DialogResult rs = MessageBox.Show("Bạn Có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                accountModel.DeleteAccount(Username);
                MessageBox.Show("Xóa Thành Công ", "Thông Báo");
                txtUserName.Text = "";
                txtName.Text = "";
                txtPassWord.Text = "";
                txtUserName.Focus();
            }
            else
            {
                this.Close();
            }
               
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccount();
            resetGridview();
                

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            resetGridview();

        }

    }
}
