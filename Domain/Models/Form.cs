using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Form
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormId { get; set; }

        [Required]
        [StringLength(100)]
        public string FormType { get; set; }
    }
}
