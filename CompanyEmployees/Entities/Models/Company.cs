using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [MaxLength(60, ErrorMessage = "Company name max length is 60")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is required")]
        [MaxLength(60, ErrorMessage = "Company address max length is 60")]
        public string Address { get; set; }

        [MaxLength(60, ErrorMessage = "Company country max length is 60")]
        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
