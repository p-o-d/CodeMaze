using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = new Guid("113628C7-D803-4DF9-8C0E-2764852F2B33"),
                    Name = "Gordon Freeman",
                    Position = "Security manager",
                    Age = 33,
                    CompanyId = new Guid("B8D0DFA1-527B-4613-9500-0558D537C089")

                },
                new Employee
                {
                    Id = new Guid("ABFA3918-6DB6-485A-B5C4-37FBA0AE2962"),
                    Name = "Alyx Vance",
                    Position = "Bartender",
                    Age = 25,
                    CompanyId = new Guid("B8D0DFA1-527B-4613-9500-0558D537C089")

                },
                new Employee
                {
                    Id = new Guid("A3716356-1A3B-4E46-99F0-CD907AA50B67"),
                    Name = "Doom guy",
                    Position = "CTO",
                    Age = 90000,
                    CompanyId = new Guid("817CB473-13D0-46E2-8E5E-A441FD3E5788")
                }
            );
        }
    }
}