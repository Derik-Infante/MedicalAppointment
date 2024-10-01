using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Insurance
{
    public class InsuranceProviders : InfoBase
    {
        int InsuranceProviderID { get; set; }
        string ContactNumber { get; set; }
        string? Website {  get; set; }
        string? City { get; set; }
        string? Country { get; set; }
        string? State { get; set; }
        string? ZipCode { get; set; }
        string ConverageDetails { get; set; }
        string? LogoUrl { get; set; }
        bool IsPreferred { get; set; }
        int NetworkTypeId { get; set; }
        string? CustomerSupportContact {  get; set; } 
        string? AcceptedRegions { get; set; }
        decimal? MaxCoverageAmount { get; set; }


    }
}
