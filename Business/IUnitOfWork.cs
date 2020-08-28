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
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Company { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
