using Business.IServices.IApp;
using Business.Repository;
using Business.Utility;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.App
{
    public class FormFieldRepository : Repository<FormField>, IFormFeildRepository
    {
        private readonly ApplicationDbContext _db;

        public FormFieldRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> ElementWidth()
        {
            var elementWidths = new List<SelectListItem>
            {
                new SelectListItem {Text =DynamicFormEnums.ElementWidth.Half.ToString() , Value = ((int)DynamicFormEnums.ElementWidth.Half).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementWidth.Full.ToString() , Value = ((int)DynamicFormEnums.ElementWidth.Full).ToString()}
            };
            return elementWidths;
        }

        public IEnumerable<SelectListItem> FieldTypes()
        {
            var fieldTypes = new List<SelectListItem>
            {
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Text.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Text).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Checkbox.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Checkbox).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.RadioButton.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.RadioButton).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.SimpleDropdown.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.SimpleDropdown).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.AutoSearchDropdown.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.AutoSearchDropdown).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.TextArea.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.TextArea).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Date.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Date).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Company.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Company).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Establishment.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Establishment).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.WorkUnit.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.WorkUnit).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Number.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Number).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.File.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.File).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Frequency.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Frequency).ToString()},
                new SelectListItem {Text =DynamicFormEnums.ElementTypes.Severity.ToString() , Value = ((int)DynamicFormEnums.ElementTypes.Severity).ToString()}
            };
            return fieldTypes;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.FormFields.Select(x => new SelectListItem()
            {
                Text = x.FieldLabel,
                Value = x.FormFieldID.ToString()
            });
        }

        public void Update(FormField formField)
        {
            var objFromDb = _db.FormFields.FirstOrDefault(i => i.FormFieldID == formField.FormFieldID);

            objFromDb.SectionId = formField.SectionId;
            objFromDb.FormId = formField.FormId;
            objFromDb.FieldLabel = formField.FieldLabel;
            objFromDb.FieldPlaceHolder = formField.FieldPlaceHolder;
            objFromDb.FieldWidth = formField.FieldWidth;
            objFromDb.IsRequired = formField.IsRequired;
            objFromDb.FieldType = formField.FieldType;
            objFromDb.DependentFieldId = formField.DependentFieldId;
            objFromDb.DependentFieldValue = formField.DependentFieldValue;
            objFromDb.FieldValueForDep = formField.FieldValueForDep;

            _db.FormFields.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
