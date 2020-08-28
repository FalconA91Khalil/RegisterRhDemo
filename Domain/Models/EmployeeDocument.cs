using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class EmployeeDocument
    {
        public long EmployeeDocumentId { get; set; }
        public long EmployeeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
