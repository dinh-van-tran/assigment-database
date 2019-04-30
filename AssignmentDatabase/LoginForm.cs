using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabase
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            
        }
        //text box type password
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        //thong báo thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát chương trình không","Thông báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }
        //xử lý buton đăng nhập
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //ẩn form 
            this.Hide();
            ///// mở form 
            frmMain form2 = new frmMain();
            form2.ShowDialog();

            this.Close();
            
        }
    }
}
