using Business.Repository.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IServices
{
    public interface ICompanyRepository : IRepository<Company>
    {
        IEnumerable<SelectListItem> GetListForDropDown();
        void Update(Company company);

    }
}
