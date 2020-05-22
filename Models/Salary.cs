using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryApp.Models
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        [DataType(DataType.Date)]
        public DateTime dayTake { get; set; }
        public int chargeTax { get; set; }
        public int chargeInsurrance { get; set; }
        public int supportCash { get; set; }
        public int basicSalary { get; set; }
        public int keepSalary { get; set; }
        public int totalSalary { get; set; }
        // public Staff Staff { get;set;}
        public int staffID{get;set;}
    }
}