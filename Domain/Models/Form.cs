using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Form
    {
        public int FormId { get; set; }

        [Required]
        [StringLength(100)]
        public string FormType { get; set; }
    }
}
