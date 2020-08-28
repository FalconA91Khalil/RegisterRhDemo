using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class WorkUnitMember
    {
        [Key]
        public int WorkMemberId { get; set; }
        public long EmployeeId { get; set; }
        public int WorkUnitId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual WorkUnit WorkUnit { get; set; }
    }
}
