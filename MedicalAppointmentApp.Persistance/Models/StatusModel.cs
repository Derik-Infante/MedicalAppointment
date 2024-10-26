using System;
using System.Collections.Generic;

namespace MedicalAppointmentApp.Persistance.Models;

public partial class StatusModel
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;
}
