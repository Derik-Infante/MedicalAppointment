namespace MedicalAppointmentApp.Domain.Result
{
    public class OperationResult<Tresult>
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
    }
}

