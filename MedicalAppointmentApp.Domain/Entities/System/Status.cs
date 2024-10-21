
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentApp.Domain.Entities.System
{
    [Table("status", Schema = "sistema")]
    public class Status
    {
        [Key]
        public int statusID { get; set; }

        public string? statusName { get; set; }

    }
}
