using MedicalAppointmentApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Insurance
{
    public class Providers : InfoBase
    {
        public int InsuranceProviderID { get; set; }
        public string ContactNumber { get; set; }
        public string? Website {  get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string ConverageDetails { get; set; }
        public string? LogoUrl { get; set; }
        bool IsPreferred { get; set; }
        int NetworkTypeId { get; set; }
        string? CustomerSupportContact {  get; set; } 
        string? AcceptedRegions { get; set; }
        decimal? MaxCoverageAmount { get; set; }


    }
}
