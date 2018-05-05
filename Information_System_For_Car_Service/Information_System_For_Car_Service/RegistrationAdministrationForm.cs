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
    public partial class RegistrationAdministrationForm : Form
    {
        public RegistrationAdministrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administration admin = new Administration();
            admin.Login = tb_login.Text;
            admin.Password = tb_password.Text;
            admin.FullName = tb_fullName.Text;
            admin.YearOfBirth = tb_yearOfBirth.Text;
            admin.Position = tb_position.Text;
            admin.Salary = tb_salary.Text;

            ExcelService excel = new ExcelService();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service\\Information System.xls";
            excel.OpenDocument(path);
            excel.WriteDataAdministration(admin);
            excel.CloseDocument();

            this.Close();
        }
    }
}
