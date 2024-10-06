using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Appointments
{
    public class Appointments : BaseEntity
    {
        int ApppointmentID { get; set; }
        int PatientID { get; set; }
        int DoctorID { get; set; }
        DateTime AppointmentDate { get; set; }
        int StatusID { get; set; }

    }
}
