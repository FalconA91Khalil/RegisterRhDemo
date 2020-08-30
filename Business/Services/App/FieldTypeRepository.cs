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
    public class FieldTypeRepository : Repository<FieldType>, IFieldTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public FieldTypeRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.FieldTypes.Select(x => new SelectListItem()
            {
                Text = x.FieldTypeName,
                Value = x.FieldTypeId.ToString()
            });
        }

        public void Update(FieldType fieldType)
        {
            var objFromDb = _db.FieldTypes.FirstOrDefault(i => i.FieldTypeId == fieldType.FieldTypeId);

            objFromDb.FieldTypeName = fieldType.FieldTypeName;
            _db.FieldTypes.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
