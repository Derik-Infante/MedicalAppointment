﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentApp.Domain.Entities.System
{
    [Table("notifications", Schema = "sistema")]
    public class Notifications
    {
        [Key]
        public int NotificationID { get; set; }

        public int UserID { get; set; }

        public string? Message { get; set; }

        DateTime SentAt { get; set; }
    }
}
