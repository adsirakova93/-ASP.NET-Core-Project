﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheBookClub.Data;
using TheBookClub.Models.AuthorModels;
using TheBookClub.Models.BookModels;
using TheBookClub.Models.BookViewModels;
using TheBookClub.Services.BookServices;
using static TheBookClub.ProjectConstants;

namespace TheBookClub.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookServices bookServices;
        private readonly TheBookClubDbContext data;

        public BookController(IBookServices bookServices, TheBookClubDbContext data)
        {
            this.bookServices = bookServices;
            this.data = data;
        }

        [Authorize]
        public IActionResult Add()
        {
            var model = new AddBookFormModel();
            model.Genres = data.Genres.Select(x => new GenreViewModel { Id = x.Id, Name = x.Name }).ToList();
            model.Author = data.Authors.Select(x => new AuthorBookSelectFormModel { Id = x.Id, FullName = x.FullName }).ToList();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddBookFormModel model)
        {
            var addBook = bookServices.AddBook(model);

            if (!ModelState.IsValid && !addBook)
            {
                model.Genres = data.Genres.Select(x => new GenreViewModel { Id = x.Id, Name = x.Name }).ToList();
                model.Author = data.Authors.Select(x => new AuthorBookSelectFormModel { Id = x.Id, FullName = x.FullName }).ToList();
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ById(int id)
        {
            var model = bookServices.BookById(id);

            return View(model);
        }

        public IActionResult All()
        {
            var model = bookServices.AllBooks();

            return View(model);
        }

        [Authorize(Roles = AdminRole + ", " + ModeratorRole)]
        public IActionResult Edit(int id)
        {
            var model = bookServices.PopulateEditBookFormModel(id);

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = AdminRole + ", " + ModeratorRole)]
        public IActionResult Edit(EditBookFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Author = data.Authors.Select(a => new AuthorBookSelectFormModel { Id = a.Id, FullName = a.FullName }).ToList();
                model.Genres = data.Genres.Select(g => new GenreViewModel { Id = g.Id, Name = g.Name }).ToList();
                return View(model);
            }

            var success = bookServices.EditBook(model);

            if (!success)
            {
                model.Author = data.Authors.Select(a => new AuthorBookSelectFormModel { Id = a.Id, FullName = a.FullName }).ToList();
                model.Genres = data.Genres.Select(g => new GenreViewModel { Id = g.Id, Name = g.Name }).ToList();
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
