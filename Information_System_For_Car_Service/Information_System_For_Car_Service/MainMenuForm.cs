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
    public partial class MainMenuForm : Form
    {
        User user;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        public MainMenuForm(User user)
        {
            InitializeComponent();
            modeForm(user);
        }
        private void modeForm(User user)
        {
            if (user.GetType() == typeof(Client))
            {
                this.user = (Client)user;
                bt_vip.Visible = false;
                bt_schedule.Visible = false;
                bt_registration.Visible = false;
                lb_fullName.Text = "Приветствуем вас, " + user.FullName;

                Client client = (Client)this.user;
                ExcelService excel = new ExcelService();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
                excel.OpenDocument(path);
                excel.ReadCurrentOrders(user);
                excel.CloseDocument();
            }
            else
            {
                this.user = (Administration)user;
                lb_fullName.Text = "Приветствуем вас, " + user.FullName;
            }
        }
        private void bt_services_Click(object sender, EventArgs e)
        {
            ServicesForm serviceForm = new ServicesForm(user);
            serviceForm.ShowDialog();
        }

        private void bt_currentOrders_Click(object sender, EventArgs e)
        {
            CurrentOrdersForm order = new CurrentOrdersForm(user);
            order.ShowDialog();
        }

        private void bt_vip_Click(object sender, EventArgs e)
        {
            StatusVIPForm vipForm = new StatusVIPForm();
            vipForm.ShowDialog();
        }
    }
}
