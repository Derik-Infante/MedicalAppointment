﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Base
{
    public class InfoBase : BaseEntity
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }

    }
}
