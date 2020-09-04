using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class FieldType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldTypeId { get; set; }

        public string FieldTypeName { get; set; }

        public ICollection<FormField> FormFields { get; set; }
    }
}
