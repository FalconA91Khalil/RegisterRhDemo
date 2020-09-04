using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Section
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SectionId { get; set; }
        public string SectionName { get; set; }      
        public bool IsDefault { get; set; }
        public ICollection<FormField> FormFields { get; set; }
    }
}
