using MedicalOprations.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalOprations.Infrastructure
{
    public class EFDataContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<MedicalRecord> MedicalRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MedicalOprations;Trusted_Connection=True;");
        }
    }
}
