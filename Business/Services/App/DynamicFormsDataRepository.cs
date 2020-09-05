using Business.IServices;
using Business.IServices.IApp;
using Business.Repository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.App
{
    public class DynamicFormsDataRepository : Repository<DynamicFormsData>, IDynamicFormsDataRepository
    {
        private readonly ApplicationDbContext _db;

        public DynamicFormsDataRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.DynamicFormsData.Select(x => new SelectListItem()
            {
                Text = x.FieldValue,
                Value = x.CompanyId.ToString()
            });
        }

        public void Update(DynamicFormsData dynamicFormData)
        {
            var objFromDb = _db.DynamicFormsData.FirstOrDefault(i => i.Id == dynamicFormData.Id);

            objFromDb.FormFieldID = dynamicFormData.FormFieldID;
            objFromDb.FieldValue = dynamicFormData.FieldValue;
            objFromDb.CompanyId = dynamicFormData.CompanyId;
            objFromDb.EstablishmentId = dynamicFormData.EstablishmentId;
            objFromDb.RiskId = dynamicFormData.RiskId;
            objFromDb.UniqueDocumentId = dynamicFormData.UniqueDocumentId;
            objFromDb.EmployeeId = dynamicFormData.EmployeeId;
            _db.DynamicFormsData.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
