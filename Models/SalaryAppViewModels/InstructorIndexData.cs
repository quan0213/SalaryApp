using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryApp.Models.SalaryAppViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Staff> staffs { get; set; }
        public IEnumerable<Salary> salaries { get; set; }
        public IEnumerable<Overtime> overtimes { get; set; }
        public IEnumerable<Allowance> allowances { get; set; }
    }
}