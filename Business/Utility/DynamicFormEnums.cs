using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Business.Utility
{
    public class DynamicFormEnums
    {
        public enum ElementTypes
        {
            [Description("Text")]
            Text = 1,

            [Description("Checkbox")]
            Checkbox = 2,

            [Description("RadioButton")]
            RadioButton = 3,

            [Description("SimpleDropdown")]
            SimpleDropdown = 4,

            [Description("AutoSearchDropdown")]
            AutoSearchDropdown = 5,

            [Description("TextArea")]
            TextArea = 6,

            [Description("Date")]
            Date = 7,

            [Description("Company")]
            Company = 8,

            [Description("Establishment")]
            Establishment = 9,

            [Description("WorkUnit")]
            WorkUnit = 10,

            [Description("Number")]
            Number = 11,

            [Description("File")]
            File = 12,

            [Description("Frequency")]
            Frequency = 13,

            [Description("Severity")]
            Severity = 14,
        }
        public enum ElementWidth
        {
            [Description("Half")]
            Half = 1,

            [Description("Full")]
            Full = 2
        }

        public enum FormType
        {
            [Description("Company")]
            Company = 1,

            [Description("Establishment")]
            Establishment = 2,

            [Description("Employee")]
            Employee = 3,

            [Description("Risk")]
            Risk = 4,

            [Description("UniqueDocument")]
            UniqueDocument = 5,

            [Description("EmployeeDocument")]
            EmployeeDocument = 6,
        }

    }
    
}
