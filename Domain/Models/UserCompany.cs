using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UserCompany
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CompanyId { get; set; }
        public bool IsMainCompany { get; set; }
    }
}
