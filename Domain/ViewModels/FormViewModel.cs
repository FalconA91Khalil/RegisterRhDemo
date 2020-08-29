using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModels
{
    public class FormViewModel
    {
        public IEnumerable<SelectListItem> FormList { get; set; }
        public IEnumerable<SelectListItem> SectionList { get; set; }
        public IEnumerable<SelectListItem> ElementWidths { get; set; }
        public IEnumerable<SelectListItem> FieldType { get; set; }
        public FormField FormField { get; set; }
    }
}
