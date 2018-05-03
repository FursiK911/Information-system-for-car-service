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
    class ExcelService
    {
        // Создаём экземпляр нашего приложения
        private Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        // Создаём экземпляр рабочий книги Excel
        private Excel.Workbook xlWorkBook;
        // Создаём экземпляр листа Excel
        private Excel.Worksheet xlWorkSheet;
        private object misValue = System.Reflection.Missing.Value;

        ~ExcelService()
        {
            CloseDocument();
        }

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
            for (int i = 1; ;i++)
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
                    user.YearOfCarManufacture = xlWorkSheet.Cells[i, 6].Text;
                    user.VIP = xlWorkSheet.Cells[i, 6].Text;
                    return true;
                }
            }
            return false;
        }

        public bool ExistAdministration(Administration user, string login, string password)
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
            for (int i = 1; ; i++)
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

        public void WriteData(Client user)
        {
            xlWorkSheet.Cells[1, 1] = "Логин";
            xlWorkSheet.Cells[1, 2] = "Пароль";
            xlWorkSheet.Cells[1, 3] = "ФИО";
            xlWorkSheet.Cells[1, 4] = "Год рождения";
            xlWorkSheet.Cells[1, 5] = "Модель автомобиля";
            xlWorkSheet.Cells[1, 6] = "VIP";

            for (int i = 1; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                {
                    xlWorkSheet.Cells[i, 1] = user.Login;
                    xlWorkSheet.Cells[i, 2] = user.Password;
                    xlWorkSheet.Cells[i, 3] = user.FullName;
                    xlWorkSheet.Cells[i, 4] = user.YearOfBirth;
                    xlWorkSheet.Cells[i, 5] = user.CarModel;
                    xlWorkSheet.Cells[i, 6] = user.YearOfCarManufacture;
                    xlWorkSheet.Cells[i, 6] = user.VIP.ToString();
                    break;
                }
            }
        }
    }
}
