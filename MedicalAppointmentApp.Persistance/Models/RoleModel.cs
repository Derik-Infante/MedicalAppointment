using System;
using System.Collections.Generic;

namespace MedicalAppointmentApp.Persistance.Models;

public partial class RoleModel
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public ulong IsActive { get; set; }
}
