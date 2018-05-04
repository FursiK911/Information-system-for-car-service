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

            for (int j = 0; j < service.Count; j++)
            {
                for (int i = 2; ; i++)
                {
                    string x = xlWorkSheet.Cells[i, 1].Text;
                    if (x == "")
                    {
                        xlWorkSheet.Cells[i, 1] = service[j].service;
                        xlWorkSheet.Cells[i, 2] = service[j].price;
                        xlWorkSheet.Cells[i, 3] = service[j].priceForVIP;
                        xlWorkSheet.Cells[i, 4] = service[j].leadTime;
                        break;
                    }
                }
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

            for (int j = 0; j < service.Count; j++)
            {
                for (int i = 2; ; i++)
                {
                    xlWorkSheet.Cells[i, 1] = service[j].service;
                    xlWorkSheet.Cells[i, 2] = service[j].price;
                    xlWorkSheet.Cells[i, 3] = service[j].priceForVIP;
                    xlWorkSheet.Cells[i, 4] = service[j].leadTime;
                    xlWorkSheet.Cells[i, 5] = service[j].status;
                    xlWorkSheet.Cells[i, 6] = service[j].customer;
                }
            }
        }

        public void ReadCurrentOrders(User user)
        {
            if ((user.GetType() == typeof(Client)))
            {
                Client client = (Client)user;
                int j = 0;
                client.services.Clear();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);

                for (int i = 2; ; i++)
                {
                    string x = xlWorkSheet.Cells[i, 1].Text;
                    if (x == "")
                        return;
                    else if(client.Login == x)
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
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);

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
