using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SalaryApp.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime dayIn { get; set; }
        public string Regency { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        // public List<Salary> Salarys {get; set;} = new List<Salary>();
        public ICollection<Salary> Salary {get;set;}

    }
}