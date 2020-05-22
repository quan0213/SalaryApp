using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryApp.Models
{
    public class Hr
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime dayIn { get; set; }
        public string Regency { get; set; }
        public string Email { get; set; }
    }
}