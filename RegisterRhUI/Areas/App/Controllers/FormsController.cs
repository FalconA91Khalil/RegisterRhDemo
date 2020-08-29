using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace RegisterRhUI.Areas.App.Controllers
{
    public class FormsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form(int type)
        {
            Form form = _unitOfWork..Where(x => x.FormType == type).Select(x => new FormDto { FormId = x.FormId, FormType = x.FormType }).FirstOrDefault();
            return View("_Form", form);
        }
    }
}
