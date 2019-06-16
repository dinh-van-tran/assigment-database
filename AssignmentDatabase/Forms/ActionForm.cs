using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabase.Forms
{
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeviceManagementButton_Click(object sender, EventArgs e)
        {
            DeviceManagementForm deviceManagementForm = new DeviceManagementForm();
            deviceManagementForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddDeviceTypeForm addDeviceTypeForm = new AddDeviceTypeForm();
            addDeviceTypeForm.Show();
        }
    }
}
