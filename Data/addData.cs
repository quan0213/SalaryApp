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

            for(int i = 7; i <= 79; i++)
            {
                DateTime temp;
                string stemp = " ";  
                if(result.Tables[0].Rows[i][4].ToString()[0] == stemp[0]){
                    temp = DateTime.Now;
                }
                else{
                    temp = DateTime.Parse(result.Tables[0].Rows[i][4].ToString());
                }
                
                context.Staffs.AddRange(
                    new Staff{
                        MaNV = result.Tables[0].Rows[i][1].ToString(),
                        Name = result.Tables[0].Rows[i][2].ToString(),
                        dayIn = temp,
                        Regency = result.Tables[0].Rows[i][3].ToString(),
                        Email = "None"
                    }
                );
                context.SaveChanges();
                    // Console.WriteLine(result.Tables[0].Rows[i][4].ToString());
            }
        }
    }
}