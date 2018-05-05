using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

namespace Information_System_For_Car_Service
{
    class ExcelService : IDocument
    {
        // Создаём экземпляр нашего приложения
        private Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        // Создаём экземпляр рабочий книги Excel
        private Excel.Workbook xlWorkBook;
        // Создаём экземпляр листа Excel
        private Excel.Worksheet xlWorkSheet;
        private object misValue = System.Reflection.Missing.Value;

        public void NewDocument()
        {
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            var xlSheets = xlWorkBook.Sheets as Excel.Sheets;
            var xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlNewSheet.Name = "Пользователи";
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[2], Type.Missing, Type.Missing, Type.Missing);
            xlNewSheet.Name = "Администрация";
            xlWorkSheet.Cells[1, 1] = "Логин";
            xlWorkSheet.Cells[1, 2] = "Пароль";
            xlWorkSheet.Cells[1, 3] = "ФИО";
            xlWorkSheet.Cells[1, 4] = "Год рождения";
            xlWorkSheet.Cells[1, 5] = "Должность";
            xlWorkSheet.Cells[1, 6] = "Зарплата";
            xlWorkSheet.Cells[2, 1] = "admin";
            xlWorkSheet.Cells[2, 2] = "admin";
            xlWorkSheet.Cells[2, 3] = "Шереметьев А.С.";
            xlWorkSheet.Cells[2, 4] = "1997";
            xlWorkSheet.Cells[2, 5] = "Системный администратор";
            xlWorkSheet.Cells[2, 6] = "8000";

            xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[3], Type.Missing, Type.Missing, Type.Missing);
            xlNewSheet.Name = "Услуги";

            xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[4], Type.Missing, Type.Missing, Type.Missing);
            xlNewSheet.Name = "Текущие заказы";

            CreateWorkSpace();
        }

        public void CreateWorkSpace()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Information System For Car Service";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public void OpenDocument(string name)
        {
            bool topicExists = false;
            xlWorkBook = xlApp.Workbooks.Open(name, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            for (int i = 1; i <= xlWorkBook.Sheets.Count; i++)
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(i);
                if (xlWorkSheet.Name == "Пользователи")
                {
                    topicExists = true;
                    break;
                }
            }

            if (!topicExists)
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;
                var xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                xlNewSheet.Name = "Пользователи";
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            }
        }

        public void CloseDocument()
        {
            xlWorkBook.Close(true, Type.Missing, Type.Missing);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        public void SaveAsDocument(string name)
        {
            xlWorkBook.SaveAs(name, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        }

        public void SaveDocument()
        {
            xlWorkBook.Save();

        }

        public bool ExcelIsPresent()
        {
            if (xlApp == null)
            {
                MessageBox.Show("Excel установлен не правильно!");
                return false;
            }
            return true;
        }

        public bool ExistClient(Client user, string login, string password)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    break;
                else if (login == xlWorkSheet.Cells[i, 1].Text && password == xlWorkSheet.Cells[i, 2].Text)
                {
                    user.Login = xlWorkSheet.Cells[i, 1].Text;
                    user.Password = xlWorkSheet.Cells[i, 2].Text;
                    user.FullName = xlWorkSheet.Cells[i, 3].Text;
                    user.YearOfBirth = xlWorkSheet.Cells[i, 4].Text;
                    user.CarModel = xlWorkSheet.Cells[i, 5].Text;
                    user.LicensePlate = xlWorkSheet.Cells[i, 6].Text;
                    user.YearOfCarManufacture = int.Parse(xlWorkSheet.Cells[i, 7].Text);
                    if (xlWorkSheet.Cells[i, 8].Text == "ЛОЖЬ")
                        user.VIP = false;
                    else
                        user.VIP = true;
                    return true;
                }
            }
            return false;
        }

        public bool ExistAdministration(Administration user, string login, string password)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    break;
                else if (login == xlWorkSheet.Cells[i, 1].Text && password == xlWorkSheet.Cells[i, 2].Text)
                {
                    user.Login = xlWorkSheet.Cells[i, 1].Text;
                    user.Password = xlWorkSheet.Cells[i, 2].Text;
                    user.FullName = xlWorkSheet.Cells[i, 3].Text;
                    user.YearOfBirth = xlWorkSheet.Cells[i, 4].Text;
                    user.Position = xlWorkSheet.Cells[i, 5].Text;
                    user.Salary = xlWorkSheet.Cells[i, 6].Text;
                    return true;
                }
            }
            return false;
        }

        public void WriteDataUser(Client user)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Логин";
            xlWorkSheet.Cells[1, 2] = "Пароль";
            xlWorkSheet.Cells[1, 3] = "ФИО";
            xlWorkSheet.Cells[1, 4] = "Год рождения";
            xlWorkSheet.Cells[1, 5] = "Модель автомобиля";
            xlWorkSheet.Cells[1, 6] = "Номерной знак";
            xlWorkSheet.Cells[1, 7] = "Год выпуска автомобиля";
            xlWorkSheet.Cells[1, 8] = "VIP";

            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                {
                    xlWorkSheet.Cells[i, 1] = user.Login;
                    xlWorkSheet.Cells[i, 2] = user.Password;
                    xlWorkSheet.Cells[i, 3] = user.FullName;
                    xlWorkSheet.Cells[i, 4] = user.YearOfBirth;
                    xlWorkSheet.Cells[i, 5] = user.CarModel;
                    xlWorkSheet.Cells[i, 6] = user.LicensePlate;
                    xlWorkSheet.Cells[i, 7] = user.YearOfCarManufacture;
                    xlWorkSheet.Cells[i, 8] = user.VIP.ToString();
                    break;
                }
            }
        }
        public void WriteDataAllUsers(List<Client> client)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Логин";
            xlWorkSheet.Cells[1, 2] = "Пароль";
            xlWorkSheet.Cells[1, 3] = "ФИО";
            xlWorkSheet.Cells[1, 4] = "Год рождения";
            xlWorkSheet.Cells[1, 5] = "Модель автомобиля";
            xlWorkSheet.Cells[1, 6] = "Номерной знак";
            xlWorkSheet.Cells[1, 7] = "Год выпуска автомобиля";
            xlWorkSheet.Cells[1, 8] = "VIP";

            int j = 2;
            for (int i = 0; i < client.Count; i++)
            {
                xlWorkSheet.Cells[j, 1] = client[i].Login;
                xlWorkSheet.Cells[j, 2] = client[i].Password;
                xlWorkSheet.Cells[j, 3] = client[i].FullName;
                xlWorkSheet.Cells[j, 4] = client[i].YearOfBirth;
                xlWorkSheet.Cells[j, 5] = client[i].CarModel;
                xlWorkSheet.Cells[j, 6] = client[i].LicensePlate;
                xlWorkSheet.Cells[j, 7] = client[i].YearOfCarManufacture;
                xlWorkSheet.Cells[j++, 8] = client[i].VIP.ToString();
            }
        }
        public List<Client> ReadDataUser()
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            List<Client> client = new List<Client>();

            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    return client;
                else
                {
                    client.Add(new Client());
                    client[client.Count - 1].Login = xlWorkSheet.Cells[i, 1].Text;
                    client[client.Count - 1].Password = xlWorkSheet.Cells[i, 2].Text;
                    client[client.Count - 1].FullName = xlWorkSheet.Cells[i, 3].Text;
                    client[client.Count - 1].YearOfBirth = xlWorkSheet.Cells[i, 4].Text;
                    client[client.Count - 1].CarModel = xlWorkSheet.Cells[i, 5].Text;
                    client[client.Count - 1].LicensePlate = xlWorkSheet.Cells[i, 6].Text;
                    client[client.Count - 1].YearOfCarManufacture = xlWorkSheet.Cells[i, 7].Text;
                    string status = xlWorkSheet.Cells[i, 8].Text;
                    if (status == "ЛОЖЬ")
                        client[client.Count - 1].VIP = false;
                    else
                        client[client.Count - 1].VIP = true;
                }
            }
        }

        public void WriteDataAdministration(Administration user)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
            xlWorkSheet.Cells[1, 1] = "Логин";
            xlWorkSheet.Cells[1, 2] = "Пароль";
            xlWorkSheet.Cells[1, 3] = "ФИО";
            xlWorkSheet.Cells[1, 4] = "Год рождения";
            xlWorkSheet.Cells[1, 5] = "Должность";
            xlWorkSheet.Cells[1, 6] = "Зарплата";

            for (int i = 1; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                {
                    xlWorkSheet.Cells[i, 1] = user.Login;
                    xlWorkSheet.Cells[i, 2] = user.Password;
                    xlWorkSheet.Cells[i, 3] = user.FullName;
                    xlWorkSheet.Cells[i, 4] = user.YearOfBirth;
                    xlWorkSheet.Cells[i, 5] = user.Position;
                    xlWorkSheet.Cells[i, 6] = user.Salary;
                    break;
                }
            }
        }

        public void WriteServiceList(List<Service> service)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
            xlWorkSheet.Cells[1, 1] = "Услуги";
            xlWorkSheet.Cells[1, 2] = "Цена";
            xlWorkSheet.Cells[1, 3] = "Цена для VIP";
            xlWorkSheet.Cells[1, 4] = "Время выполнения";

            int i = 2;
            for (int j = 0; j < service.Count; j++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                xlWorkSheet.Cells[i, 1] = service[j].service;
                xlWorkSheet.Cells[i, 2] = service[j].price;
                xlWorkSheet.Cells[i, 3] = service[j].priceForVIP;
                xlWorkSheet.Cells[i, 4] = service[j].leadTime;
                xlWorkSheet.Cells[i + 1, 1] = "";
                xlWorkSheet.Cells[i + 1, 2] = "";
                xlWorkSheet.Cells[i + 1, 3] = "";
                xlWorkSheet.Cells[i++ + 1, 4] = "";
            }

        }

        public void ReadServiceList(List<Service> service)
        {
            int j = 0;
            service.Clear();
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);

            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    return;
                else
                {
                    service.Add(new Service());
                    service[j].service = xlWorkSheet.Cells[i, 1].Text;
                    service[j].price = xlWorkSheet.Cells[i, 2].Text;
                    service[j].priceForVIP = xlWorkSheet.Cells[i, 3].Text;
                    service[j++].leadTime = xlWorkSheet.Cells[i, 4].Text;
                }
            }
        }

        public void WriteCurrentOrders(List<Service> service)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);
            xlWorkSheet.Cells[1, 1] = "Услуги";
            xlWorkSheet.Cells[1, 2] = "Цена";
            xlWorkSheet.Cells[1, 3] = "Цена для VIP";
            xlWorkSheet.Cells[1, 4] = "Время выполнения";
            xlWorkSheet.Cells[1, 5] = "Текущие заказы";
            xlWorkSheet.Cells[1, 6] = "Заказчик";

            int i = 2;
            for (int j = 0; j < service.Count; j++)
            {
                xlWorkSheet.Cells[i, 1] = service[j].service;
                xlWorkSheet.Cells[i, 2] = service[j].price;
                xlWorkSheet.Cells[i, 3] = service[j].priceForVIP;
                xlWorkSheet.Cells[i, 4] = service[j].leadTime;
                xlWorkSheet.Cells[i, 5] = service[j].status;
                xlWorkSheet.Cells[i++, 6] = service[j].customer;
            }
        }

        public void ReadCurrentOrders(User user)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);
            if ((user.GetType() == typeof(Client)))
            {
                Client client = (Client)user;
                int j = 0;
                client.services.Clear();
                

                for (int i = 2; ; i++)
                {
                    string x = xlWorkSheet.Cells[i, 6].Text;
                    if (x == "")
                        return;
                    else if(client.FullName == x)
                    {
                        client.services.Add(new Service());
                        client.services[j].service = xlWorkSheet.Cells[i, 1].Text;
                        client.services[j].price = xlWorkSheet.Cells[i, 2].Text;
                        client.services[j].priceForVIP = xlWorkSheet.Cells[i, 3].Text;
                        client.services[j].leadTime = xlWorkSheet.Cells[i, 4].Text;
                        client.services[j].status = xlWorkSheet.Cells[i, 5].Text;
                        client.services[j++].customer = xlWorkSheet.Cells[i, 6].Text;
                    }
                }
            }

            else
            {
                Administration admin = (Administration)user;
                int j = 0;
                admin.services.Clear();

                for (int i = 2; ; i++)
                {
                    string x = xlWorkSheet.Cells[i, 1].Text;
                    if (x == "")
                        return;
                    else
                    {
                        admin.services.Add(new Service());
                        admin.services[j].service = xlWorkSheet.Cells[i, 1].Text;
                        admin.services[j].price = xlWorkSheet.Cells[i, 2].Text;
                        admin.services[j].priceForVIP = xlWorkSheet.Cells[i, 3].Text;
                        admin.services[j].leadTime = xlWorkSheet.Cells[i, 4].Text;
                        admin.services[j].status = xlWorkSheet.Cells[i, 5].Text;
                        admin.services[j++].customer = xlWorkSheet.Cells[i, 6].Text;
                    }
                }
            }
        }

        public List<string> GetListClient()
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            List<string> listClient = new List<string>();
            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    break;
                else
                {
                    listClient.Add(xlWorkSheet.Cells[i, 1].Text);
                }
            }
            return listClient;
        }

        public void setVIPStatus(string login, bool status)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            for (int i = 2; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                    break;
                else if (login == x)
                {
                    xlWorkSheet.Cells[i, 8] = status.ToString();
                    return;
                }
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
