using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }      
        public bool IsDefault { get; set; }
     
    }
}
