using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    interface IAuthorization
    {
        bool ExistClient(Client user, string login, string password);
        bool ExistAdministration(Administration user, string login, string password);
    }
}
