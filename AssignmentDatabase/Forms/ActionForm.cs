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

        private void addDeviceTypeButton_Click(object sender, EventArgs e)
        {
            AddDeviceTypeForm addDeviceTypeForm = new AddDeviceTypeForm();
            addDeviceTypeForm.Show();
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm();
            addDeviceForm.Show();
        }
    }
}
