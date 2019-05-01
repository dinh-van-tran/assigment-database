using AssignmentDatabase.Models;
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
    public partial class AddDeviceForm : Form
    {
        public AddDeviceForm()
        {
            InitializeComponent();
        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            LoadDeviceType();
        }

        private void LoadDeviceType()
        {
            DeviceTypeModel deviceTypeModel = new DeviceTypeModel();
            List<DeviceType> deviceTypes = deviceTypeModel.GetAllDeviceTypes();

            deviceTypeListBox.DisplayMember = "Name";
            deviceTypeListBox.DataSource = deviceTypes;
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            object selectedItem = deviceTypeListBox.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một loại thiết bị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number = (int)numberUpDown.Value;
            if (number == 0)
            {
                MessageBox.Show("Số lượng thiết bị phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int value = (int)valueUpDown.Value;

            string code = codeTextBox.Text.Trim();
            DeviceType selectedType = (DeviceType)selectedItem;
            DeviceModel deviceModel = new DeviceModel();
            deviceModel.AddDevice(selectedType.Code, code, value);
        }
    }
}
