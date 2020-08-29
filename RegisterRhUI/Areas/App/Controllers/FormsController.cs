using System;
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
    public class FormsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public FormViewModel formVM { get; set; }

        public FormsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            formVM = new FormViewModel()
            {
                FormField = new FormField(),
                SectionList = _unitOfWork.Sections.GetListForDropDown(),
                FormList = _unitOfWork.Forms.GetListForDropDown(),
                ElementWidths = _unitOfWork.FormFeilds.ElementWidth(),
                FieldType = _unitOfWork.FormFeilds.FieldTypes()
            };
            if (id != null)
            {
                formVM.FormField = _unitOfWork.FormFeilds.Get(id.GetValueOrDefault());
            }
            return View(formVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (formVM.FormField.FormFieldID == 0)
                {
                    _unitOfWork.FormFeilds.Add(formVM.FormField);
                }
                else
                {
                    _unitOfWork.FormFeilds.Update(formVM.FormField);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(formVM.FormField);
        }

        #region API CALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.FormFeilds.GetAll() });
            //return Json(new { data = _unitOfWork.SP_Call.ReturnList<Category>(SD.usp_GetAllCategory, null) });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.FormFeilds.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            else
            {
                _unitOfWork.FormFeilds.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Deleted successful." });
            }
        }
        #endregion
    }
}
