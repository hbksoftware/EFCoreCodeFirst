using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEntity
{
    public class EfCCoreDBContext :DbContext
    { 
        public EfCCoreDBContext(DbContextOptions<EfCCoreDBContext> options) : base(options) { }
        public EfCCoreDBContext(){}
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAdress> EmployeeAdresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectEntityConfiguration());
        }
    } 
}
