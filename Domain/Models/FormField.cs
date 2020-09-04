using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class FormField:AuditEntities
    {
        public FormField()
        {
            Section = new HashSet<Section>();
            Form = new HashSet<Form>();
            FieldType = new HashSet<FieldType>();
        }
        [Key]
        public int FormFieldID { get; set; }
        public int FormId { get; set; }
        public int SectionId { get; set; }
        public string FieldLabel { get; set; }
        public string FieldPlaceHolder { get; set; }
        public int FieldWidth { get; set; }
        public bool IsRequired { get; set; }
        public int FieldTypeId { get; set; }
        public int? DependentFieldId { get; set; }
        public string DependentFieldValue { get; set; }
        public string FieldValueForDep { get; set; }

        public virtual ICollection<Section> Section { get; set; }
        public virtual ICollection<Form> Form { get; set; }
        public virtual ICollection<FieldType> FieldType { get; set; }
    }
}
