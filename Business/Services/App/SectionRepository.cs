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
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        private readonly ApplicationDbContext _db;

        public SectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.Sections.Select(x => new SelectListItem()
            {
                Text = x.SectionName,
                Value = x.SectionId.ToString()
            });
        }

        public void Update(Section section)
        {
            var objFromDb = _db.Sections.FirstOrDefault(i => i.SectionId == section.SectionId);
            objFromDb.SectionName = section.SectionName;

            _db.Sections.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
