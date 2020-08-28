using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int FormId { get; set; }
        public bool IsDefault { get; set; }
        public virtual Form Form { get; set; }
    }
}
