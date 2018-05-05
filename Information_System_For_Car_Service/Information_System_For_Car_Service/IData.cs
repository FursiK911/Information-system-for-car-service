using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    interface IData
    {
        void WriteDataUser(Client user);
        void WriteDataAdministration(Administration user);
    }
}
