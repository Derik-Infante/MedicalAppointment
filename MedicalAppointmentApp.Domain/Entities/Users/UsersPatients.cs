using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Users
{
    public class UsersPatients : InfoBase
    {
        int PatientID { get; set; }
        DateTime DateOfBirth { get; set; }
        string Gender { get; set; }
        string PhoneNumber { get; set; }
        string EmergencyContactName { get; set; }
        string EmergencyContactPhone { get; set;}
        string BloodType { get; set; }
        string Allergies { get; set; }
        int InsuranceProviderID { get; set; }


    }
}
