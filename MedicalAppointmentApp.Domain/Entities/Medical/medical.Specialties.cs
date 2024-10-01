namespace MedicalAppointmentApp.Domain.Entities.Medical
{
    public sealed class Specialties
    {
        public int SpecialtyID { get; set; }
        public string SpecialtyName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
