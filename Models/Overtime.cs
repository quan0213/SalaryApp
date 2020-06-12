using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryApp.Models
{
    [Table("Overtime")]
    public class Overtime
    {
        [Key]
        public int OverTimeId { get; set;}
        
        public int dayOff {get; set;}
        public int overtimeHours{get; set;}
        public long overtimeSalary{get;set;}

        //temp for Staffid
        public int staffTerm{get;set;}
        
        //Tham chiếu tới salary
        public Salary Salary{get;set;}
        public int SalaryId{get;set;}

        //Tham chieu toi allowance
        public Allowance Allowance{get;set;}
    }
}