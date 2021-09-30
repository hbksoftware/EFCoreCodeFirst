using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace EFCoreEntity
{
    public class EmployeeAdress
    {
        [Key]
        public int AdressID { get; set; }
        public string Adress { get; set; }
        public Employee Employee { get; set; }
    }

    public class EmployeeAdressEntityConfiguration : IEntityTypeConfiguration<EmployeeAdress>
    {
        public void Configure(EntityTypeBuilder<EmployeeAdress> builder)
        {
            builder.HasKey(e => e.AdressID);

            //One To One(Employee - EmployeeAdress)
            builder.HasOne<Employee>(x => x.Employee)
                .WithOne(x => x.EmployeeAdress)
                .HasForeignKey<Employee>(x => x.AdressID);
        }
    }
}
