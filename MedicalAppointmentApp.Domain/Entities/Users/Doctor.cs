using MedicalAppointmentApp.Domain.Base;


namespace MedicalAppointmentApp.Domain.Entities.Users
{
    public  class Doctor : BaseEntity
    {
        public int DoctorID { get; set; }
        public short SpecialtyID { get; set; }
        public string LicenseNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public int YersOfExperience { get; set; }
        public string? Education {  get; set; }
        public string? Bio { get; set; }
        public string? ConsultationFee { get; set; }
        public string? ClinicAddress { get; set; }
        public short AvailabilityModeId { get; set; }
        public DateTime LicenseExpirationDate { get; set; }

    }
}
