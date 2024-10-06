using MedicalAppointmentApp.Domain.Base;

namespace MedicalAppointmentApp.Domain.Entities.Insurance
{
    public class NetworkType : InfoBase
    {
        public int NetworkTypeId { get; set; }
        public string? Description { get; set; }

    }
}
