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
    public partial class BaseClientsForm : Form
    {
        List<Client> client;
        public BaseClientsForm()
        {
            InitializeComponent();
        }

        private void ms_delete_Click(object sender, EventArgs e)
        {

        }

        private void BaseClientsForm_Load(object sender, EventArgs e)
        {
            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            excel.OpenDocument(path);
            client = excel.ReadDataUser();
            excel.CloseDocument();

            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dgv_info.Rows.Clear();
            for (int i = 0; i < client.Count; i++)
            {
                dgv_info.Rows.Add(client[i].Login, client[i].Password, client[i].FullName, client[i].YearOfBirth, client[i].CarModel, client[i].LicensePlate, client[i].YearOfCarManufacture, client[i].VIP);
            }
        }

        private void BaseClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            excel.OpenDocument(path);

            FillClientList();
            excel.WriteDataAllUsers(client);
            excel.CloseDocument();
        }

        private void FillClientList()
        {
            dgv_info.EndEdit();
            client.Clear();
            
            for (int i = 0; i < dgv_info.RowCount - 1; i++)
            {
                int j = 0;
                client.Add(new Client());
                client[client.Count - 1].Login = dgv_info[j++,i].Value.ToString();
                client[client.Count - 1].Password = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].FullName = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].YearOfBirth = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].CarModel = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].LicensePlate = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].YearOfCarManufacture = dgv_info[j++, i].Value.ToString();
                client[client.Count - 1].VIP = bool.Parse(dgv_info[j, i].Value.ToString());
            }
        }
    }
}
