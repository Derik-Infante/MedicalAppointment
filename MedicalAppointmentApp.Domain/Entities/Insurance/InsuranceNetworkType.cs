﻿using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Insurance
{
    internal class InsuranceNetworkType : InfoBase
    {
        int NetworkTypeId { get; set; }
        string Description { get; set; }

    }
}
