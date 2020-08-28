using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class registreRhColumnSetting
    {
        [Key]
        public int ColumnSettingId { get; set; }
        public int FormId { get; set; }
        public int ColumnFieldId { get; set; }
        public int ColumnOrder { get; set; }
        public bool IsDefault { get; set; }
    }
}
