﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain.Models;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RegisterRhUI.Areas.App.Controllers
{
    [Area("App")]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public CompanyViewModel company { get; set; }
        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? FormFieldID)
        {
            if (FormFieldID == null)
            {
                company.FormFields = _unitOfWork.FormFeilds.GetAll(filter: x => x.FormId == 1, includeProperties: "Form,Section,FieldType").ToList();
                return View(company);
            }

            company.Company = _unitOfWork.Companies.Get(FormFieldID.GetValueOrDefault());
            company.FormFields = _unitOfWork.FormFeilds.GetAll(filter:x=>x.FormId == 1, includeProperties:"Form").ToList();
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company company)
        {
            if (ModelState.IsValid)
            {
                if (company.CompanyId == 0)
                {
                    _unitOfWork.Companies.Add(company);
                }
                else
                {
                    _unitOfWork.Companies.Update(company);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        #region API CALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Companies.GetAll() });
            //return Json(new { data = _unitOfWork.SP_Call.ReturnList<Category>(SD.usp_GetAllCategory, null) });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Companies.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            else
            {
                _unitOfWork.Companies.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Deleted successful." });
            }
        }
        #endregion
    }
}
