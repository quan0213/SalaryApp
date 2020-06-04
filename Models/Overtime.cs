using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryApp.Models
{
    [Table("Overtime")]
    public class Overtime
    {
        [Key]
        public int Id { get; set; }
        public int SalaryId{get;set;}
        public int dayOff {get; set;}
        public int overtimeHours{get; set;}
        public int overtimeSalary{get;set;}
        
        //Tham chiếu tới salary
        public virtual Salary Salary{get;set;}
    }
}