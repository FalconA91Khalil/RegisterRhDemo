using Business.Repository.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IServices.IApp
{
    public interface IFormFeildRepository : IRepository<FormField>
    {
        IEnumerable<SelectListItem> GetListForDropDown();
        IEnumerable<SelectListItem> ElementWidth();
        IEnumerable<SelectListItem> FieldTypes();
        void Update(FormField form);
    }
}
