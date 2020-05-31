using ExcelDataReader;
using SalaryApp.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace SalaryApp.Data
{
    public static class addData
    {
        public static void Initialize(SalaryAppContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Staffs.Any())
            {
                return;   // DB has been seeded
            }
            //Read xlsx File

            FileStream stream = File.Open("Data/Book1.xlsx", FileMode.Open, FileAccess.Read);
            
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet result = excelReader.AsDataSet();

            Console.WriteLine(result.Tables[0].Rows[7][2]);
            
            excelReader.Close();

        }
    }
}