using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModEmployee.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [Range(1, 100000)]
        public DateTime Birthday { get; set; }
        [Required]
        public string Recomendation { get; set; }
    }
}