using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryApp.Models
{
    [Table("Allowance")]
    public class Allowance
    {
        [Key]
        public int Id { get; set; }
        public int OvertimeId{get;set;}
        public int bonusKPI {get; set;}
        public int uniformsCharge {get; set;}
        public int phoneCharge {get;set;}
        public int lunchCharge {get;set;}

        //Tham chiếu tới salary
        public virtual Overtime Overtime{get; set;}
    }
}