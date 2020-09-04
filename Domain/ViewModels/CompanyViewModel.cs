using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModels
{
    public class CompanyViewModel
    {
        public Company Company { get; set; }

        public List<FormField> FormFields { get; set; }
        public List<FieldType> FieldTypes { get; set; }
    }
}
