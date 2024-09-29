using MedicalAppointmentApp.Domain.Base.InsuranceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.Insurance.InsuranceProviders
{
    public class InsuranceInsuranceProviders : InsuranceBase
    {
        int InsuranceProviderID { get; set; } 
        string ContactNumber { get; set; }  
        string Email { get; set; }
        string? WebSite { get; set; }
        string Address { get; set; }
        string? city { get; set; }
        string? state { get; set; }
        string? country { get; set; }
        string? ZipCode { get; set; }
        string CoverageDetails {get; set; }
        string? LogoUrl { get; set; } 
        bool IsPreferred { get; set; }
        
        string? CustomerSupportContact { get; set; }
        string? AcceptedRegions { get; set; }
        decimal? MaxCoverageAmount { get; set; }
      



    }
}
