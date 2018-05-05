using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_System_For_Car_Service
{
    public partial class ServicesForm : Form
    {
        List<Service> service = new List<Service>();
        User user;
        public ServicesForm()
        {
            InitializeComponent();
        }

        public ServicesForm(User user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(Client))
                this.user = (Client)user;
            else
                this.user = (Administration)user;
           
        }

        private void Services_Load(object sender, EventArgs e)
        {
            ExcelService excel = new ExcelService();
            if ((user.GetType() == typeof(Administration)))
            {
                col_services.ReadOnly = false;
                col_price.ReadOnly = false;
                col_priceForVIP.ReadOnly = false;
                col_leadTime.ReadOnly = false;
                ms_toOrder.Visible = false;
            }
            else
            {
                ms_delete.Visible = false;
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";

            if (excel.ExcelIsPresent())
            {
                if (File.Exists(path))
                    excel.OpenDocument(path);
                else
                    excel.NewDocument();

                excel.ReadServiceList(service);
                FillDataGridView();
                excel.CloseDocument();
            }
        }

        private void FillDataGridView()
        {
            dgv_service.Rows.Clear();
            for (int i = 0; i < service.Count; i++)
            {
                dgv_service.Rows.Add(service[i].service,service[i].price,service[i].priceForVIP,service[i].leadTime);
            }
        }

        private void FillService()
        {
            service.Clear();
            int j = 0;
            for (int i = 0; i < dgv_service.RowCount - 1; i++)
            {
                j = 0;
                service.Add(new Service());
                service[service.Count - 1].service = dgv_service[j++, i].Value.ToString();
                service[service.Count - 1].price = dgv_service[j++, i].Value.ToString();
                service[service.Count - 1].priceForVIP = dgv_service[j++, i].Value.ToString();
                service[service.Count - 1].leadTime = dgv_service[j, i].Value.ToString();
            }
        }

        private void ms_comeback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ms_toOrder_Click(object sender, EventArgs e)
        {
            Client client = (Client)user;
            client.services.Add(service[dgv_service.CurrentCell.RowIndex]);
            client.services[client.services.Count - 1].status = "Выполняется";
            client.services[client.services.Count - 1].customer = client.FullName;

            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            if (excel.ExcelIsPresent())
            {
                if (File.Exists(path))
                    excel.OpenDocument(path);
                else
                    excel.NewDocument();

                excel.WriteCurrentOrders(client.services);
                excel.CloseDocument();
            }
            MessageBox.Show("Заказ совершен!");
        }

        private void ServicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((user.GetType() == typeof(Administration)))
            {
                Administration admin = (Administration)user;
                ExcelService excel = new ExcelService();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
                if (excel.ExcelIsPresent())
                {
                    if (File.Exists(path))
                        excel.OpenDocument(path);
                    else
                        excel.NewDocument();

                    FillService();
                    excel.WriteServiceList(service);
                    excel.CloseDocument();
                }
            }
        }

        private void ms_delete_Click(object sender, EventArgs e)
        {
            if(dgv_service.SelectedRows != null)
            {
                dgv_service.Rows.RemoveAt(dgv_service.CurrentCell.RowIndex);
            }
        }
    }
}
