using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public int AttributeId { get; set; }
        public string OptionText { get; set; }
        public string OptionUrl { get; set; }
        public virtual FormField Attribute { get; set; }
    }
}
