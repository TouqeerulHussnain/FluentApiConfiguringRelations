﻿// <auto-generated />
using System;
using FluentApiConfiguringRelations.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentApiConfiguringRelations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240705135106_OneToOneRelation")]
    partial class OneToOneRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FluentApiConfiguringRelations.Core.Model.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FluentApiConfiguringRelations.Core.Model.EmployeeDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeesDetails");
                });

            modelBuilder.Entity("FluentApiConfiguringRelations.Core.Model.EmployeeDetails", b =>
                {
                    b.HasOne("FluentApiConfiguringRelations.Core.Model.Employee", "Employee")
                        .WithOne("EmployeeDetails")
                        .HasForeignKey("FluentApiConfiguringRelations.Core.Model.EmployeeDetails", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FluentApiConfiguringRelations.Core.Model.Employee", b =>
                {
                    b.Navigation("EmployeeDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
