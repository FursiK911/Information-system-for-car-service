using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Information_System_For_Car_Service
{
    public partial class RegistrationForm : Form
    {
        Client client = new Client();
        ExcelService excel = new ExcelService();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {

            if (allFieldsFull() && excel.ExcelIsPresent())
            {
                client.Login = tb_login.Text;
                client.Password = tb_password.Text;
                client.FullName = tb_fullName.Text;
                client.YearOfBirth = tb_year.Text;
                client.CarModel = tb_modelCar.Text;
                client.YearOfCarManufacture = tb_yearOfCar.Text;
                client.VIP = false;

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
                if (File.Exists(path))
                {
                    excel.OpenDocument(path);
                }
                else
                {
                    excel.NewDocument();
                }

                if (!excel.ExistClient(client, tb_login.Text, tb_password.Text))
                {
                    excel.WriteData(client);
                }

                else
                    MessageBox.Show("Пользователь с таким логином уже существует!");

                if (!File.Exists(path))
                    excel.SaveAsDocument(path);
                else
                    excel.SaveDocument();

                excel.CloseDocument();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool allFieldsFull()
        {
            if (tb_fullName.Text != "" && tb_login.Text != "" && tb_modelCar.Text != "" && tb_password.Text != "" && tb_year.Text != "")
                return true;
            return false;
        }
    }
}
