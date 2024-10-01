﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Base
{
    public abstract class BaseEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime? UpadatedAt { get; set; }
        bool IsActive { get; set; }

    }
}
