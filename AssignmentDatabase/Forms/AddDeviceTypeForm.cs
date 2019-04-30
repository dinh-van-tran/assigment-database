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
        public AddDeviceTypeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string code = codeTextbox.Text.Trim();
            string name = nameTextbox.Text.Trim();
            string description = descriptionTextbox.Text.Trim();

            Connection connection = new Connection();
            connection.ExcuteQuery("INSERT INTO DeviceType(Code, Name, Description) VALUES ('"+ code +"', N'" + name +"', N'" + description + "')");
            connection.Close();
        }
    }
}
