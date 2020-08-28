using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class WorkUnit
    {
        [Key]
        public int WorkUnitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
