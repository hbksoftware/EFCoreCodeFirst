using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreEntity
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string EmployeeName { get; set; }
        public int AdressID { get; set; }
        public EmployeeAdress EmployeeAdress { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeID);

            /// One To One(Employee-To-EmployeeAdress)
            builder.HasOne<EmployeeAdress>(agn => agn.EmployeeAdress)
                .WithOne(agnu => agnu.Employee)
                .HasForeignKey<Employee>(agency => agency.AdressID)
                .OnDelete(DeleteBehavior.Cascade);

            /// One To Many(Department-To-Employee)
            builder.HasOne(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentID);
        }
    }
}
