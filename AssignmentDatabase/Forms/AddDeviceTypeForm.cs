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

namespace AssignmentDatabase
{
    public partial class AddDeviceTypeForm : Form
    {
        private DeviceTypeModel deviceTypeModel = new DeviceTypeModel();
        
        private BindingSource bindingSource = new BindingSource();
        
        
        public AddDeviceTypeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addDeviceType();
            refreshGridView();
        }

        private void addDeviceType()
        {
            string code = codeTextbox.Text.Trim();
            string name = nameTextbox.Text.Trim();
            string description = descriptionTextbox.Text.Trim();

            if (deviceTypeModel.CheckExist(code))
            {
                MessageBox.Show("Mã thiết bị đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            deviceTypeModel.Add(code, name, description);
            MessageBox.Show("Thêm thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void refreshGridView()
        {
            List<DeviceType> deviceTypes = deviceTypeModel.GetAll();
            bindingSource.DataSource = deviceTypes;
        }

        private void AddDeviceTypeForm_Load(object sender, EventArgs e)
        {
            loadDeviceTypesToGridView();
        }

        private void loadDeviceTypesToGridView()
        {
            List<DeviceType> deviceTypes = deviceTypeModel.GetAll();
            bindingSource.DataSource = deviceTypes;
            deviceTypeGridView.DataSource = bindingSource;
        }

        private void deviceTypeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 