
using MedicalAppointmentApp.Domain.Base;

namespace MedicalAppointmentApp.Domain.Entities.AppointmentsAppointments
{
    public sealed class MedicalRecords : BaseEntity
    {
        public int RecordID { get; set; }
        public int PatiendID { get; set; }
        public int DoctorID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateOfVisit { get; set; }
    }
}
