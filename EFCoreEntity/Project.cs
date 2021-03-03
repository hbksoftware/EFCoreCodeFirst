using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEntity
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
