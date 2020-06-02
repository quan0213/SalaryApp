using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalaryApp.Models;

namespace SalaryApp.Models.SalaryViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Staff> Staffs { get; set; }
        public IEnumerable<Salary> Salaries { get; set; }
    }
}