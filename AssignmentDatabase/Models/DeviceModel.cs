using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabase.Models
{
    public class DeviceModel
    {
        public void AddDevice(string type, string code, int value)
        {
            Connection connection = new Connection();
            connection.ExcuteQuery("INSERT INTO Device(Type, Code, Value) VALUES ('" + type + "', N'" + code + "', '" + value + "')");
            connection.Close();
        }
    }
}
