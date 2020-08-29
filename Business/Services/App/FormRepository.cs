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
    public class FormRepository : Repository<Form>, IFormRepository
    {
        private readonly ApplicationDbContext _db;

        public FormRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.Forms.Select(x => new SelectListItem()
            {
                Text = x.FormType.ToString(),
                Value = x.FormId.ToString()
            });
        }

        public void Update(Form form)
        {
            var objFromDb = _db.Forms.FirstOrDefault(i => i.FormId == form.FormId);

            objFromDb.FormType = form.FormType;

            _db.Forms.Update(objFromDb);
            _db.SaveChanges();
        }
        public string GetElementTypeString(int type)
        {
            string Type = string.Empty;
            if (type == (int)DynamicFormEnums.ElementTypes.Text)
            {
                Type = "Text";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.AutoSearchDropdown)
            {
                Type = "Auto Search Dropdown";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.Checkbox)
            {
                Type = "Checkbox";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.RadioButton)
            {
                Type = "Radio Button";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.SimpleDropdown)
            {
                Type = "Simple Dropdown";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.TextArea)
            {
                Type = "Text Area";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.Date)
            {
                Type = "Date";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.Number)
            {
                Type = "Number";
            }
            else if (type == (int)DynamicFormEnums.ElementTypes.File)
            {
                Type = "File";
            }
            return Type;
        }

    }
}
