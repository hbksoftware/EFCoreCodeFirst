using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            /// One To Many(Employee - To - EmployeeProjects)
            builder.HasOne(e => e.Employee)
                 .WithMany(ep => ep.EmployeeProjects)
                 .HasForeignKey(e => e.EmployeeID);

            /// One To Many(Project - To - EmployeeProjects)
            builder.HasOne(e => e.Project)
                 .WithMany(ep => ep.EmployeeProjects)
                 .HasForeignKey(e => e.ProjectID);
        }
    }
}
