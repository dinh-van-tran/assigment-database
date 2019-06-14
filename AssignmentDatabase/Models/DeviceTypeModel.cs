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
        DataClassesDataContext db = new DataClassesDataContext();

        public void Add(string code, string name, string description)
        {
            DeviceType newRow = new DeviceType();
            newRow.Code = code;
            newRow.Name = name;
            newRow.Description = description;

            db.DeviceTypes.InsertOnSubmit(newRow);
            db.SubmitChanges();
        }
        public List<DeviceType> GetAllDeviceTypes()
        {
            var deviceTypeQuery = from deviceTypes in db.DeviceTypes
                                  select deviceTypes;

            List<DeviceType> result = new List<DeviceType>();
            foreach (var deviceType in deviceTypeQuery)
            {
                result.Add(deviceType);
            }

            return result;
        }

        public bool CheckExist(string code)
        {
            if (db.DeviceTypes.Any(deviceType => deviceType.Code == code))
            {
                return true;
            }

            return false;
        }
    }
}
