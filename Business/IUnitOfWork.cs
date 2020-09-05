using Business.IServices;
using Business.IServices.IApp;
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
        ICompanyRepository Companies { get; }
        IFormRepository Forms { get; }
        IFormFeildRepository FormFeilds { get; }
        ISectionRepository Sections { get; }
        IFieldTypeRepository FieldTypes { get; }
        IDynamicFormsDataRepository DynamicFormsData { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
