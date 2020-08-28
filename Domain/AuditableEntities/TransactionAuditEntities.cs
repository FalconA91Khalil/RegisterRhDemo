using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.AuditableEntities
{
    public class TransactionAuditEntities
    {
        [Column(TypeName = "NCHAR")]
        [StringLength(20)]
        public string ReferenceID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "NCHAR")]
        [StringLength(10)]
        public string DocID { get; set; }

        public DateTime DocDate { get; set; }

        public DateTime? DueDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(20)]
        public string DocBarcode { get; set; }

        [StringLength(500)]
        public string Remarks { get; set; }

        public string RequestTypeCode { get; set; }

        public string StatusCode { get; set; }

        [Column(TypeName = "NCHAR")]
        [StringLength(10)]
        public string Tag { get; set; }

        [Column(TypeName = "NCHAR")]
        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }

}
