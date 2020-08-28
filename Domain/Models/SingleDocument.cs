using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class SingleDocument
    {
        public int SingleDocumentId { get; set; }
        public int EstablishmentId { get; set; }
        public virtual Establishment Establishment { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string PublishedById { get; set; }
        public string SingleDocumentInfo { get; set; }
        public string Methodology { get; set; }
        public string CompanyInformation { get; set; }
        public string Effective { get; set; }
        public string HealthPartner { get; set; }
        public string OccupHealthIndicator { get; set; }
    }
}
