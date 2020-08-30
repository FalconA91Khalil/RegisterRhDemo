using Business.IServices;
using Business.IServices.IApp;
using Business.Repository;
using Business.Repository.IRepository;
using Business.Services;
using Business.Services.App;
using Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            SP_Call = new SP_Call(_db);
            Companies = new CompanyRepository(_db);
            Forms = new FormRepository(_db);
            FormFeilds = new FormFieldRepository(_db);
            Sections = new SectionRepository(_db);
            FieldTypes = new FieldTypeRepository(_db);
        }

        public ISP_Call SP_Call { get; set; }

        public ICompanyRepository Companies { get; set; }

        public IFormRepository Forms { get; set; }

        public IFormFeildRepository FormFeilds { get; set; }

        public ISectionRepository Sections { get; set; }

        public IFieldTypeRepository FieldTypes { get; set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }

}
