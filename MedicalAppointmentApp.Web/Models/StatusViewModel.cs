namespace MedicalAppointmentApp.Web.Models
{
    public class StatusViewModel
    {
        public int StatusId { get; set; }        
        public string? StatusName { get; set; }   
        public DateTime CreatedAt { get; set; }  
        public DateTime UpdatedAt { get; set; }  
        public bool IsActive { get; set; }       
    }
}
