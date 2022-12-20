using SuperDoc.Areas.Admin.Models.MedicalCenters;
using SuperDoc.Models.MedicalCenters.Enums;
using SuperDoc.Services.MedicalCenters;
using Microsoft.AspNetCore.Mvc;

namespace SuperDoc.Areas.Admin.Controllers
{
    public class MedicalCentersController : AdminController
    {
        private readonly IMedicalCenterService medicalCenters;

        public MedicalCentersController(IMedicalCenterService medicalCenters) 
            => this.medicalCenters = medicalCenters;

        public IActionResult All(AllMedicalCentersAdminQueryModel query)
        {
            var queryResult = this.medicalCenters
                    .All(
                        null,
                        null,
                        query.SearchTerm,
                        MedicalCentersSorting.DateCreated,
                        query.CurrentPage,
                        AllMedicalCentersAdminQueryModel.MedicalCentersPerPage
                        );

            query.MedicalCenters = queryResult.MedicalCenters;
            query.TotalMedicalCenters = queryResult.TotalMedicalCenters;

            return View(query);
        }
    }
}
