using BeautyZone.Models;
using BeautyZone.Services.MedicalCenters;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeautyZone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMedicalCenterService medicalCenters;

        public HomeController(IMedicalCenterService medicalCenters)
        {
            this.medicalCenters = medicalCenters;
        }

        public IActionResult Index()
        {
            var medicalCenters = this.medicalCenters.GetMedicalCenters();

            return View(medicalCenters);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
