using Microsoft.AspNetCore.Mvc;
using TheBookClub.Services.GenreServices;

namespace TheBookClub.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreServices genreServices;

        public GenreController(IGenreServices genreServices)
        {
            this.genreServices = genreServices;
        }

        public IActionResult All()
        {
            var model = genreServices.ViewAllGenres();

            return View(model);
        }

        public IActionResult ById(int id)
        {
            var model = genreServices.GenreByIdView(id);

            return View(model);
        }
    }
}
