using MedicalAppointmentApp.Domain.Base;

namespace MedicalAppointmentApp.Domain.Entities.Medical
{
    public sealed class AvailabilityModes : BaseEntity
    {
        public int SA_vailabilityModeID { get; set; }
        public char AvailabilityMode { get; set; }
    }
}
