using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Domain.Models
{
    public class registreRhSetting
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public bool IsEstablishment { get; set; }
        public string Logo { get; set; }
        public bool MainAppLogo { get; set; }
        public bool IsWindowAuthentication { get; set; }
    }
}
