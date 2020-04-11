using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class CustomerDAO
    {
        private String cmnd;
        private String name;
        private String phoneNumber;
        private String roomId;

        public CustomerDAO()
        {
        }

        public CustomerDAO(string cmnd, string name, string phoneNumber, string roomId)
        {
            this.cmnd = cmnd;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.roomId = roomId;
        }

        public override string ToString()
        {
            return this.name + this.cmnd + this.phoneNumber;
        }

        public String CMND { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String RoomId { get; set; }
    }
}
