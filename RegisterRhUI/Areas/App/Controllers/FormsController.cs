using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace RegisterRhUI.Areas.App.Controllers
{
    [Area("App")]
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

        public IActionResult Upsert(int? id)
        {
            Form form = new Form();
            if (id == null)
            {
                return View(form);
            }

            form = _unitOfWork.Forms.Get(id.GetValueOrDefault());
            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Form form)
        {
            if (ModelState.IsValid)
            {
                if (form.FormId == 0)
                {
                    _unitOfWork.Forms.Add(form);
                }
                else
                {
                    _unitOfWork.Forms.Update(form);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(form);
        }

        #region API CALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Forms.GetAll() });
            //return Json(new { data = _unitOfWork.SP_Call.ReturnList<Category>(SD.usp_GetAllCategory, null) });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Forms.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            else
            {
                _unitOfWork.Forms.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Deleted successful." });
            }
        }
        #endregion
    }
}
