using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEntity
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAdress EmployeeAdress { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeID);

            builder.HasOne(e => e.EmployeeAdress)
                .WithOne(e => e.Employee)
                .HasForeignKey<EmployeeAdress>(e => e.AdressID);

            builder.HasOne(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentID);
        }
    }
}
