using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class registreRhHistory
    {
        [Key]
        public int HistoryId { get; set; }
        public long ItemId { get; set; }
        public int ItemType { get; set; }
        public string data { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAdded { get; set; }
    }
}
