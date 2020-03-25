using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = new Guid("B8D0DFA1-527B-4613-9500-0558D537C089"),
                    Name = "Horns and Bones",
                    Address = "1 Av 45 building",
                    Country = "Ukraine"
                },
                new Company
                {
                    Id = new Guid("817CB473-13D0-46E2-8E5E-A441FD3E5788"),
                    Name = "It Cheese",
                    Address = "5 Av 6 building",
                    Country = "US"
                }
            );
        }
    }
}
