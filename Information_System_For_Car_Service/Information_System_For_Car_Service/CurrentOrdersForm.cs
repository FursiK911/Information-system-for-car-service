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
                    dgv_service.Rows.Add(client.services[i].service, client.services[i].price, client.services[i].priceForVIP, client.services[i].leadTime, client.services[i].status, client.services[i].customer);
                }
            }
            else
            {
                Administration admin = (Administration)user;
                for (int i = 0; i < admin.services.Count; i++)
                {
                    dgv_service.Rows.Add(admin.services[i].service, admin.services[i].price, admin.services[i].priceForVIP, admin.services[i].leadTime, admin.services[i].customer);
                }
            }
        }

        private void dgv_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
