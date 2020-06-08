using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SalaryApp.Models
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int SalaryId{get;set;}

        [DataType(DataType.Date)]
        public DateTime dayTake{ get; set; }
        public int chargeTax { get; set; }
        public int chargeInsurrance { get; set; }
        public int supportCash { get; set; }
        public int basicSalary { get; set; }
        public int keepSalary { get; set; }
        public int totalSalary { get; set; }

        //Foreign key: Staff 1->N Salary
        public Staff Staff{get;set;}
        public int StaffId{get;set;}

        //Foreign key: Salary 1->N Overtime
        public ICollection<Overtime> Overtimes{get;set;}
        // public virtual ICollection<Allowance> Allowances{get;set;}
    }
}