using Business.IServices;
using Business.Repository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> GetListForDropDown()
        {
            return _db.Companies.Select(x => new SelectListItem()
            {
                Text = x.CompanyName,
                Value = x.CompanyId.ToString()
            });
        }

        public void Update(Company company)
        {
            var objFromDb = _db.Companies.FirstOrDefault(i => i.CompanyId == company.CompanyId);

            objFromDb.CompanyName = company.CompanyName;
            objFromDb.ImageUrl = company.ImageUrl;
            objFromDb.ModifiedBy = company.ModifiedBy;
            objFromDb.ModifiedDate = company.ModifiedDate;
            _db.Companies.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
