 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreEntity
{
    public class EmployeeAdress
    {
        [Key]
        public int AdressID { get; set; }
        public string Adress { get; set; }
        public Employee Employee { get; set; }
    }
}
