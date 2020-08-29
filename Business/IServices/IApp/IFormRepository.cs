using Business.Repository.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IServices.IApp
{
    public interface IFormRepository : IRepository<Form>
    {
        IEnumerable<SelectListItem> GetListForDropDown();
        void Update(Form form);

    }
}
