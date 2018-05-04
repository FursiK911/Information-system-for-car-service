using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    class Service
    {
        public string service { get; set; }
        public string price { get; set; }
        public string priceForVIP { get; set; }
        public string leadTime { get; set; }
        public string status { get; set; }
        public string customer { get; set; }
        public void CalculatePriceForVIP(int percent)
        {
            //priceForVIP = (price / 100) * percent;
        }
    }
}
