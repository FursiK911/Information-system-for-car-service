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
    public partial class AuthorizationForm : Form
    {
        Client client = new Client();
        Administration admin = new Administration();
        ExcelService excel = new ExcelService();
        public AuthorizationForm()
        {
            InitializeComponent();
            tb_password.UseSystemPasswordChar = cb_viewPassword.Checked;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";

            if (excel.ExcelIsPresent())
            {
                if (File.Exists(path))
                {
                    excel.OpenDocument(path);
                }
                else
                {
                    excel.NewDocument();
                }

                if (excel.ExistAdministration(admin, tb_login.Text, tb_password.Text))
                {
                    this.Hide();
                    excel.CloseDocument();
                    MainMenuForm menu = new MainMenuForm(admin);
                    menu.ShowDialog();
                }

                else if (excel.ExistClient(client, tb_login.Text, tb_password.Text))
                {
                    this.Hide();
                    excel.CloseDocument();
                    MainMenuForm menu = new MainMenuForm(client);
                    menu.ShowDialog();
                }

                else
                    MessageBox.Show("Пользователь с таким логином и паролем не найден!");

                this.Close();
            }

        }

        private void cb_viewPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = cb_viewPassword.Checked;
        }

        private void llb_register_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.ShowDialog();
        }
    }
}
