using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalOprations.Infrastructure.Entities
{
    [Table("Patients", Schema = "dbo")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PatientId { get; set; }
        public string? Name { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid CreatedBy { get; set; } = Guid.NewGuid();
    }
}
