using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MedicalOprations.Domain.Enum.Enumeration;

namespace MedicalOprations.Infrastructure.Entities
{
    public class MedicalRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MedicalRecordId { get; set; }
        public PatientStatus Status { get; set; }
        public string? NotesText { get; set; }
        public Guid Doctor { get; set; }
        public DateTime NextAppointment { get; set; }
        [ForeignKey("PatientId")]
        [Required]
        public Guid PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
