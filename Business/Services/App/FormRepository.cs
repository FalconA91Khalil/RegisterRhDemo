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
    }
}
