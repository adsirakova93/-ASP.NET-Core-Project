using BeautyZone.Areas.Admin.Models.MedicalCenterTypes;
using BeautyZone.Areas.Admin.Services.MedicalCenterTypes;
using Microsoft.AspNetCore.Mvc;

namespace BeautyZone.Areas.Admin.Controllers
{
    public class MedicalCenterTypesController : AdminController
    {
        private readonly ITypeService types;

        public MedicalCenterTypesController(ITypeService types)
            => this.types = types;

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TypeFormModel type)
        {
            if (this.types.IsExisting(type.Name))
            {
                this.ModelState.AddModelError(nameof(type.Name), "Medical Center Type already exists.");
            }

            if (!this.ModelState.IsValid)
            {
                return View(type);
            }

            this.types.Add(type.Name);

            this.TempData[WebConstants.GlobalSuccessMessageKey] = string.Format(WebConstants.AddMedicalCenterTypeSuccessMessage, type.Name);

            return RedirectToAction(nameof(Add));
        }
    }
}
