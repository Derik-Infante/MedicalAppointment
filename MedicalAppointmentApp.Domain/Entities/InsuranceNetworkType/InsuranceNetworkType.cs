using MedicalAppointmentApp.Domain.Base.InsuranceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.InsuranceNetworkType
{
    internal class InsuranceNetworkType : InsuranceBase
    {
        string? Description { get; set; }
    }
}
