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
        public long bonusKPI {get; set;}
        public long uniformsCharge {get; set;}
        public long phoneCharge {get;set;}
        public long lunchCharge {get;set;}

        //temp for Staffid
        public int staffTerm{get;set;}

        //Tham chiếu tới salary
        public int OvertimeId{get;set;}
        public Overtime Overtime{get; set;}
    }
}