using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModels
{
    public class CompanyViewModel
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public List<FormField> FormFields { get; set; }
    }
}
