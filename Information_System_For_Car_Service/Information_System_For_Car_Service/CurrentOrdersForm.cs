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
    public partial class CurrentOrdersForm : Form
    {
        User user;
        public CurrentOrdersForm()
        {
            InitializeComponent();
        }

        public CurrentOrdersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void вернутьсяВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrentOrdersForm_Load(object sender, EventArgs e)
        {
            if ((user.GetType() == typeof(Client)))
            {
                col_customer.Visible = false;
                Client client = (Client)user;
                for (int i = 0; i < client.services.Count; i++)
                {
                    if (client.FullName == client.services[i].customer)
                        dgv_service.Rows.Add(client.services[i].service, client.services[i].price, client.services[i].priceForVIP, client.services[i].leadTime, client.services[i].status, client.services[i].customer);
                }
            }
            else
            {
                col_status.ReadOnly = false;
                col_price.ReadOnly = false;
                col_priceForVIP.ReadOnly = false;
                col_order.ReadOnly = false;
                col_leadTime.ReadOnly = false;
                col_customer.ReadOnly = false;
                Administration admin = (Administration)user;
                ExcelService excel = new ExcelService();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
                excel.OpenDocument(path);
                excel.ReadCurrentOrders(admin);
                excel.CloseDocument();
                for (int i = 0; i < admin.services.Count; i++)
                {
                    dgv_service.Rows.Add(admin.services[i].service, admin.services[i].price, admin.services[i].priceForVIP, admin.services[i].leadTime, admin.services[i].status, admin.services[i].customer);
                }
            }
        }

        private void CurrentOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user.GetType() == typeof(Administration))
            {
                Administration admin = (Administration)user;
                ExcelService excel = new ExcelService();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
                FillService(admin);
                excel.OpenDocument(path);
                excel.WriteCurrentOrders(admin.services);
                excel.CloseDocument();
            }
        }
        private void FillService(Administration admin)
        {
            admin.services.Clear();
            int j = 0;
            for (int i = 0; i < dgv_service.RowCount - 1; i++)
            {
                j = 0;
                admin.services.Add(new Service());
                admin.services[admin.services.Count - 1].service = dgv_service[j++, i].Value.ToString();
                admin.services[admin.services.Count - 1].price = dgv_service[j++, i].Value.ToString();
                admin.services[admin.services.Count - 1].priceForVIP = dgv_service[j++, i].Value.ToString();
                admin.services[admin.services.Count - 1].leadTime = dgv_service[j++, i].Value.ToString();
                admin.services[admin.services.Count - 1].status = dgv_service[j++, i].Value.ToString();
                admin.services[admin.services.Count - 1].customer = dgv_service[j, i].Value.ToString();
            }
        }
    }
}
