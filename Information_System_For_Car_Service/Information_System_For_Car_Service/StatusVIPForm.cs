using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_System_For_Car_Service
{
    public partial class StatusVIPForm : Form
    {
        public StatusVIPForm()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            excel.OpenDocument(path);
            excel.setVIPStatus(cb_users.SelectedItem.ToString(),cb_vipStatus.Checked);
            excel.CloseDocument();
        }

        private void StatusVIPForm_Load(object sender, EventArgs e)
        {
            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            excel.OpenDocument(path);
            List<string> listClient = excel.GetListClient();
            excel.CloseDocument();
            for (int i = 0; i < listClient.Count; i++)
            {
                cb_users.Items.Add(listClient[i]);
            }
        }
    }
}
