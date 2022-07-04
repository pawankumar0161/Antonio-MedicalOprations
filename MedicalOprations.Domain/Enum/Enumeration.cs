using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOprations.Domain.Enum
{
    public class Enumeration
    {
        public enum PatientStatus
        {
            none,
            Sick,
            Normal,
            InTreatment,
            Cured
        }
    }

}
