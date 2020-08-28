﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class FormField
    {
        public int FormFieldID { get; set; }
        public int SectionId { get; set; }
        public string FieldLabel { get; set; }
        public string FieldPlaceHolder { get; set; }
        public int FieldWidth { get; set; }
        public bool IsRequired { get; set; }
        public int FieldType { get; set; }
        public int? DependentFieldId { get; set; }
        public string DependentFieldValue { get; set; }
        public string FieldValueForDep { get; set; }
        public virtual Section Section { get; set; }
    }
}
