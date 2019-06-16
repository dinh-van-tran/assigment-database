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
            loadDeviceType();
            loadUser();
        }

        private void loadDeviceType()
        {
            DeviceTypeModel deviceTypeModel = new DeviceTypeModel();
            List<DeviceType> deviceTypes = deviceTypeModel.GetAll();

            deviceTypeListBox.DisplayMember = "Name";
            deviceTypeListBox.DataSource = deviceTypes;
        }

        private void loadUser()
        {
            AccountModel model = new AccountModel();

            userComboBox.DisplayMember = "Name";
            userComboBox.DataSource = model.GetAll();
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

            DeviceModel deviceModel = new DeviceModel();
            DeviceType selectedType = (DeviceType)selectedItem;

            string description = this.descriptionTextBox.Text;
            Account user = (Account)userComboBox.SelectedItem;

            int value = (int)valueUpDown.Value;
            for (int i = 0; i < number; i++)
            {
                string code = selectedType.Code + randomString(4) + i;
                Device device = new Device();
                device.Code = code;
                device.Type = selectedType.Code;
                device.Value = value;
                device.Description = description;
                device.Owner = user.Username;
                deviceModel.AddDevice(device);
            }
        }

        private string randomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
