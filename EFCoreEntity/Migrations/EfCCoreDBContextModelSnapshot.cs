﻿// <auto-generated />
using System;
using EFCoreEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreEntity.Migrations
{
    [DbContext(typeof(EfCCoreDBContext))]
    partial class EfCCoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EFCoreEntity.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCoreEntity.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdressID")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("AdressID")
                        .IsUnique();

                    b.HasIndex("DepartmentID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCoreEntity.EmployeeAdress", b =>
                {
                    b.Property<int>("AdressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdressID");

                    b.ToTable("EmployeeAdresses");
                });

            modelBuilder.Entity("EFCoreEntity.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "ProjectID");

                    b.HasIndex("ProjectID");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("EFCoreEntity.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EFCoreEntity.Employee", b =>
                {
                    b.HasOne("EFCoreEntity.EmployeeAdress", "EmployeeAdress")
                        .WithOne("Employee")
                        .HasForeignKey("EFCoreEntity.Employee", "AdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreEntity.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreEntity.Project", null)
                        .WithMany("Employees")
                        .HasForeignKey("ProjectID");

                    b.Navigation("Department");

                    b.Navigation("EmployeeAdress");
                });

            modelBuilder.Entity("EFCoreEntity.EmployeeProject", b =>
                {
                    b.HasOne("EFCoreEntity.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreEntity.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("EFCoreEntity.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EFCoreEntity.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("EFCoreEntity.EmployeeAdress", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EFCoreEntity.Project", b =>
                {
                    b.Navigation("EmployeeProjects");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
