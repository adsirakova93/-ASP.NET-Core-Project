using System;
using System.Collections.Generic;
using System.Linq;
using TheBookClub.Data;
using TheBookClub.Models.AuthorModels;
using TheBookClub.Models.BookModels;
using TheBookClub.Models.BookViewModels;

namespace TheBookClub.Services.BookServices
{
    public class BookServices : IBookServices
    {
        private readonly TheBookClubDbContext data;

        public BookServices(TheBookClubDbContext data)
        {
            this.data = data;
        }

        public bool AddBook(AddBookFormModel book)
        {
            var author = data.Authors.Where(x => x.Id == book.AuthorId).FirstOrDefault();

            if (author == null)
            {
                return false;
            }

            var bookToAdd = new Data.DBModels.BookPendingApproval
            {
                Title = book.Title,
                Author = author,
                Description = book.Description,
                ImageURL = book.ImageURL,
                ReleaseYear = book.ReleaseYear,
            };

            foreach (var genre in book.GenresId)
            {
                var confirmGenre = data.Genres.Where(x => x.Id == genre).FirstOrDefault();

                if (confirmGenre == null)
                {
                    return false;
                }

                bookToAdd.Genres.Add(confirmGenre);
            }

            data.BookPendingApprovals.Add(bookToAdd);
            data.SaveChanges();
            return true;
        }

        public ICollection<AllBooksViewModel> AllBooks()
        {
            var model = data.Books
                .Select(x => new AllBooksViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageURL = x.ImageURL,
                    ReleaseYear = x.ReleaseYear,
                }).OrderBy(x => x.Title).ToList();

            return model;
        }

        public BookByIdViewModel BookById(int id)
        {
            var model = data.Books
                .Where(x => x.Id == id)
                .Select(x => new BookByIdViewModel
                {
                    Id = x.Id,
                    Author = x.Author.FullName,
                    AuthorId = x.AuthorId,
                    Description = x.Description,
                    ImageURL = x.ImageURL,
                    ReleaseYear = x.ReleaseYear,
                    Title = x.Title,
                    Genres = x.Genres.Select(g => new GenreViewModel { Id = g.Id, Name = g.Name }).ToList(),
                }).FirstOrDefault();

            return model;
        }

        public bool EditBook(EditBookFormModel model)
        {
            var book = data.Books.Where(x => x.Id == model.Id).FirstOrDefault();

            if (book != null)
            {
                book.Title = model.Title;
                book.ReleaseYear = model.ReleaseYear;
                book.ImageURL = model.ImageURL;
                foreach (var genre in model.GenresId)
                {
                    book.Genres = data.Genres.Where(x => x.Id == genre).ToList();
                }
                book.Description = model.Description;
                book.AuthorId = model.AuthorId;

                data.SaveChanges();
                return true;
            }

            return false;
        }

        public EditBookFormModel PopulateEditBookFormModel(int id)
        {
            var model = data.Books
                .Where(x => x.Id == id)
                .Select(x => new EditBookFormModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    ReleaseYear = x.ReleaseYear,
                    ImageURL = x.ImageURL,
                    Title = x.Title,
                }).FirstOrDefault();

            model.Author = data.Authors.Select(a => new AuthorBookSelectFormModel { Id = a.Id, FullName = a.FullName }).ToList();
            model.Genres = data.Genres.Select(g => new GenreViewModel { Id = g.Id, Name = g.Name }).ToList();

            return model;
        }

        public ICollection<IndexBookViewModel> PopulateIndexBooks()
        {
            var model = data.Books
                .OrderByDescending(x => x.Id)
                .Select(x => new IndexBookViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageURL = x.ImageURL,
                }
                ).Take(3).ToList();

            return model;
        }
    }
}
