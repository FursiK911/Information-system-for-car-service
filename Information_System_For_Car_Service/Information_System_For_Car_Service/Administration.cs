using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    class Administration : User
    {
        public string Position { get; set; }
        public string Salary { get; set; }

        public List<Service> services = new List<Service>();
    }
}
