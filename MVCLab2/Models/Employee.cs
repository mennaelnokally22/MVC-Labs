using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCLab2.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Range(3000,100000)]
        public int Salary { get; set; }
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
    }
}