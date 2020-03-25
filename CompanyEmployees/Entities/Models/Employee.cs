using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        [MaxLength(60, ErrorMessage = "Employee name max length is 30")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employee position is required")]
        [MaxLength(60, ErrorMessage = "Employee position max length is 20")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Employee age is required")]
        public int Age { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
