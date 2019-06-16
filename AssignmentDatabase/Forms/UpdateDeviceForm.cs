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
    public partial class UpdateDeviceForm : Form
    {
        private DeviceModel deviceModel = new DeviceModel();
        private DeviceTypeModel deviceTypeModel = new DeviceTypeModel();
        private AccountModel accountModel = new AccountModel();

        private string deviceCode;
        private Device device;

        private bool loaded = false;
        public UpdateDeviceForm(string deviceCode)
        {
            this.deviceCode = deviceCode;
            InitializeComponent();
        }

        private void UpdateDeviceForm_Load(object sender, EventArgs e)
        {
            this.device = this.deviceModel.GetByCode(this.deviceCode);
            this.codeTextBox.Text = this.device.Code;
            this.valueTextBox.Text = this.device.Value.ToString();
            this.descriptionTextBox.Text = this.device.Description;

            this.userComboBox.DisplayMember = "Name";
            List<Account> accounts = this.accountModel.GetAll();
            this.userComboBox.DataSource = accounts;
            for (int i = 0; i < accounts.Count; i++)
            {
                var account = accounts[i];
                if (account.Username == this.device.Owner)
                {
                    this.userComboBox.SelectedIndex = i;
                    break;
                }
            }

            this.deviceTypeComboBox.DisplayMember = "Name";
            List<DeviceType> deviceTypes = this.deviceTypeModel.GetAll();
            this.deviceTypeComboBox.DataSource = deviceTypes;
            for (int i = 0; i < deviceTypes.Count; i++)
            {
                var deviceType = deviceTypes[i];
                if (deviceType.Code == this.device.Type)
                {
                    this.deviceTypeComboBox.SelectedIndex = i;
                    break;
                }
            }

            loaded = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.device.Value = Decimal.Parse(this.valueTextBox.Text);
            this.device.Description = this.descriptionTextBox.Text;
            this.deviceModel.Update(this.device);
        }

        private void DeviceTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }

            var selectedDeviceType = (DeviceType) this.deviceTypeComboBox.SelectedItem;
            this.device.Type = selectedDeviceType.Code;
        }

        private void UserComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }

            var selectedUser = (Account)this.userComboBox.SelectedItem;
            this.device.Owner = selectedUser.Username;
        }
    }
}
