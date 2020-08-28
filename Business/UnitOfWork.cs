using Business.IServices;
using Business.Repository;
using Business.Repository.IRepository;
using Business.Services;
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
            Company = new CompanyRepository(_db);
        }

        public ISP_Call SP_Call { get; set; }

        public ICompanyRepository Company { get; set; }

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
