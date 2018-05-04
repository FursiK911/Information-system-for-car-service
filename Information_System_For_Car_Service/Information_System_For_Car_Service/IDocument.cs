using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System_For_Car_Service
{
    interface IDocument
    {
        void NewDocument();
        void OpenDocument(string name);
        void SaveAsDocument(string name);
        void SaveDocument();
        void CloseDocument();
    }
}
