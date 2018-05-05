using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    class Client : User
    {
        public string CarModel { get; set; }
        public string LicensePlate { get; set; }
        public string YearOfCarManufacture { get; set; }
        public bool VIP { get; set; }

        public List<Service> services = new List<Service>();
    }
}
