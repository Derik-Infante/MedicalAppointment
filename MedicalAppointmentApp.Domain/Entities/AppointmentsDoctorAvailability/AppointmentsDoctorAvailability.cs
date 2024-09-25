using MedicalAppointmentApp.Domain.Base.AppointmentBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.AppointmentsDoctorAvailability
{
    public sealed class AppointmentsDoctorAvailability : AppointmentBase
    {
        int AvailabilityID { get; set; }   
        DateTime AvailableDate {  get; set; }
        TimeOnly  StartTime { get; set; }
        TimeOnly EndTime { get; set; }
    }
}
