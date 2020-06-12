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
        public long chargeTax { get; set; }
        public long chargeInsurrance { get; set; }
        public long supportCash { get; set; }
        public long basicSalary { get; set; }
        public long keepSalary { get; set; }
        public long totalSalary { get; set; }

        //Foreign key: Staff 1->N Salary
        public Staff Staff{get;set;}
        public int StaffId{get;set;}

        //Foreign key: Salary 1->N Overtime
        public ICollection<Overtime> Overtimes{get;set;}
        // public virtual ICollection<Allowance> Allowances{get;set;}
    }
}