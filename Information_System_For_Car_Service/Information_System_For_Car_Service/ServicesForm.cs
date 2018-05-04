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
        ExcelService excel = new ExcelService();
        User user;
        public ServicesForm()
        {
            InitializeComponent();
        }

        public ServicesForm(User user)
        {
            InitializeComponent();
            this.user = (Client)user;
        }

        private void Services_Load(object sender, EventArgs e)
        {
            try
            {
                if ((user.GetType() == typeof(Client)))
                    ms_discount.Visible = false;

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";

                if (excel.ExcelIsPresent())
                {
                    if (File.Exists(path))
                        excel.OpenDocument(path);
                    else
                        excel.NewDocument();

                    excel.ReadServiceList(service);
                    FillDataGridView();
                    
                }
            }
            finally
            {
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
            MessageBox.Show("Заказ совершен!");
        }

        private void ms_discount_Click(object sender, EventArgs e)
        {
        }
    }
}
