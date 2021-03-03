using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEntity
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
