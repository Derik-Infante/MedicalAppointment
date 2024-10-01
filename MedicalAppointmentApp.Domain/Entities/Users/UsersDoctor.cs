using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Users
{
    internal class UsersDoctor : BaseEntity
    {
        int DoctorID { get; set; }
        short SpecialtyID { get; set; }
        string LicenseNumber { get; set; }
        string PhoneNumber { get; set; }
        int YersOfExperience { get; set; }
        string Education {  get; set; }
        string? Bio { get; set; }
        string? ConsultationFee { get; set; }
        string? ClinicAddress { get; set; }
        short AvailabilityModeId { get; set; }
        DateTime LicenseExpirationDate { get; set; }



    }
}
