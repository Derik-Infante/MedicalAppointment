using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Users
{
    internal class UserUsers : InfoBase
    {
        int UserID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        int RoleID { get; set; }
    }
}
