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
    public partial class DeviceManagementForm : Form
    {
        DeviceModel model = new DeviceModel();

        public DeviceManagementForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm();
            addDeviceForm.Show();
        }

        private void DeviceManagementForm_Load(object sender, EventArgs e)
        {
            this.loadDevices();
        }

        private void loadDevices()
        {
            this.deviceDataView.DataSource = model.GetAllDevices();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.deviceDataView.SelectedRows)
            {
                var deviceCode = row.Cells[0].Value.ToString();
                model.DeleteDeviceByCode(deviceCode);
            }

            this.loadDevices();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var selectedRows = this.deviceDataView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                return;
            }

            UpdateDeviceForm updateDeviceForm = new UpdateDeviceForm(selectedRows[0].Cells[0].Value.ToString());
            updateDeviceForm.Show();
        }
    }
}
