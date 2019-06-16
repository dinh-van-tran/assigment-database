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

        public void AddDevice(Device device)
        {
            db.Devices.InsertOnSubmit(device);
            db.SubmitChanges();
        }

        public Device GetByCode(string code)
        {
            return db.Devices.First(d => d.Code == code);
        }

        public IQueryable<DeviceView> GetAllDevices()
        {
            var deviceQuery = from device in db.DeviceViews
                              select device;

            return deviceQuery;
        }

        public List<Device> GetDevicesByUser(string username)
        {
            var deviceQuery = from device in db.Devices
                              where device.Owner == username
                              select device;

            List <Device> result = new List<Device>();
            foreach(var device in deviceQuery)
            {
                result.Add(device);
            }

            return result;
        }

        public void Update(Device device)
        {
            db.SubmitChanges();
        }

        public void DeleteDeviceByCode(string code)
        {
            var device = db.Devices.First(d => d.Code == code);
            if (device == null)
            {
                return;
            }

            db.Devices.DeleteOnSubmit(device);
            db.SubmitChanges();
        }
    }
}
