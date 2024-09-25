using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Base.InsuranceBase
{
    public abstract class InsuranceBase
    {
        string Name { get; set; }
        int NetworkTypeId { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsActive { get; set; }
    }
}
