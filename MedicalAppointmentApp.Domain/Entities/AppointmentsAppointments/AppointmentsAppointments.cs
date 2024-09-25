using MedicalAppointmentApp.Domain.Base.AppointmentBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities
{
    public sealed class AppointmentsAppointments : AppointmentBase
    {
        int AppointmentID { get; set; }
        int PatientID { get; set; }
        DateTime AppointmentDate { get; set; }
        int StatusID { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        
        

    }
}
