using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EstablishmentPricipal { get; set; }
        public int? CompanyId { get; set; }
        public bool IsMainCompany { get; set; }
    }
}
