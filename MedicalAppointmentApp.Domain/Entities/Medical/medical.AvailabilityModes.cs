namespace MedicalAppointmentApp.Domain.Entities.Medical
{
    public sealed class AvailabilityModes
    {
        public int SA_vailabilityModeID { get; set; }
        public char AvailabilityMode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
