﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyEmployees.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"),
                            Address = "1 Av 45 building",
                            Country = "Ukraine",
                            Name = "Horns and Bones"
                        },
                        new
                        {
                            Id = new Guid("817cb473-13d0-46e2-8e5e-a441fd3e5788"),
                            Address = "5 Av 6 building",
                            Country = "US",
                            Name = "It Cheese"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("113628c7-d803-4df9-8c0e-2764852f2b33"),
                            Age = 33,
                            CompanyId = new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"),
                            Name = "Gordon Freeman",
                            Position = "Security manager"
                        },
                        new
                        {
                            Id = new Guid("abfa3918-6db6-485a-b5c4-37fba0ae2962"),
                            Age = 25,
                            CompanyId = new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"),
                            Name = "Alyx Vance",
                            Position = "Bartender"
                        },
                        new
                        {
                            Id = new Guid("a3716356-1a3b-4e46-99f0-cd907aa50b67"),
                            Age = 90000,
                            CompanyId = new Guid("817cb473-13d0-46e2-8e5e-a441fd3e5788"),
                            Name = "Doom guy",
                            Position = "CTO"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.HasOne("Entities.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
