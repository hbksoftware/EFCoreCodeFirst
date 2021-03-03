using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEntity
{
    public class EmployeeProject
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
    public class EmployeeProjectEntityConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.HasKey(ep => new { ep.EmployeeID, ep.ProjectID });
            builder.HasOne(e => e.Employee)
                 .WithMany(ep => ep.EmployeeProjects)
                 .HasForeignKey(e => e.EmployeeID);

            builder.HasOne(e => e.Project)
                 .WithMany(ep => ep.EmployeeProjects)
                 .HasForeignKey(e => e.ProjectID);
        }
    }
}
