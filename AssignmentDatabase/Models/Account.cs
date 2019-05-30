using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabase.Models
{
    public  class Account
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        /// <summary>
        /// /
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //
        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        //Create UPDATE 
        private DateTime updatedDate;

        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

    }
}
