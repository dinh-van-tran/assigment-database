using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabase.Models
{
    public class DeviceModel
    {
        DataClassesDataContext db = new DataClassesDataContext();

        public void AddDevice(string type, string code, int value)
        {
            Device newRow = new Device();
            newRow.Type = type;
            newRow.Code = code;
            newRow.Value = value;

            db.Devices.InsertOnSubmit(newRow);
            db.SubmitChanges();
        }


        public List<Device> getAllDevices()
        {
            var deviceQuery = from device in db.Devices
                              select device;
            List<Device> result = new List<Device>();
            foreach(var device in deviceQuery)
            {
                result.Add(device);
            }

            return result;
        }

        public List<Device> getDevicesByUser(string username)
        {
            List<Device> result = new List<Device>();
            return result;
        }
    }
}
