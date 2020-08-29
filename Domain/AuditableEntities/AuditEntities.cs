using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.AuditableEntities
{
    public class AuditEntities
    {
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(100)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

    }

}
