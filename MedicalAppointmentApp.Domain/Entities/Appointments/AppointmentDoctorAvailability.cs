using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Appointments
{
    internal class AppointmentDoctorAvailability
    {
        int AvailabilityID { get; set; }
        int DoctorID { get; set; }
        DateTime AvailableDate { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}
