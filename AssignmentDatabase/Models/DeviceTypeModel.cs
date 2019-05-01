using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabase.Models
{
    public class DeviceTypeModel
    {
        public void Add(string code, string name, string description)
        {
            Connection connection = new Connection();
            connection.ExcuteQuery("INSERT INTO DeviceType(Code, Name, Description) VALUES ('" + code + "', N'" + name + "', N'" + description + "')");
            connection.Close();
        }

        public List<DeviceType> GetAllDeviceTypes()
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("Select * FROM DeviceType;");

            List<DeviceType> result = new List<DeviceType>();
            while (reader.Read())
            {
                DeviceType deviceType = new DeviceType();
                deviceType.Code = reader["Code"].ToString();
                deviceType.Name = reader["Name"].ToString();
                deviceType.Description = reader["Description"].ToString();
                deviceType.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                deviceType.UpdatedDate = DateTime.Parse(reader["UpdatedDate"].ToString());

                result.Add(deviceType);
            }

            connection.Close();

            return result;
        }

        internal bool CheckExist(string code)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExcuteQuery("SELECT TOP 1 * FROM DeviceType WHERE Code = '" + code + "';");

            bool found = reader.HasRows;
            connection.Close();

            return found;
        }
    }
}
