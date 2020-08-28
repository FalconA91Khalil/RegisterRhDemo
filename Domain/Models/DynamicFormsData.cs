using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class DynamicFormsData
    {
        public int Id { get; set; }
        public int FormFieldID { get; set; }
        public string FieldValue { get; set; }
        public long? EmployeeId { get; set; }
        public int? CompanyId { get; set; }
        public int? RiskId { get; set; }
        public int? UniqueDocumentId { get; set; }
        public virtual Company Company { get; set; }
        public int? EstablishmentId { get; set; }
        public virtual Establishment Establishment { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual FormField FormField { get; set; }
        public virtual Risk Risk { get; set; }
        public virtual UniqueDocument UniqueDocument { get; set; }
        public long? EmployeeDocumentId { get; set; }
        public virtual EmployeeDocument EmployeeDocument { get; set; }
    }
}
