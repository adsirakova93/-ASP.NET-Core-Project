using System.Collections.Generic;
using System.Linq;
using TheBookClub.Data;
using TheBookClub.Models.BookModels;
using TheBookClub.Models.BookViewModels;
using TheBookClub.Models.GenreModels;

namespace TheBookClub.Services.GenreServices
{
    public class GenreServices : IGenreServices
    {
        private readonly TheBookClubDbContext data;

        public GenreServices(TheBookClubDbContext data)
        {
            this.data = data;
        }

        public GenreByIdViewModel GenreByIdView(int id)
        {
            var model = data.Genres
                 .Where(x => x.Id == id)
                 .Select(x => new GenreByIdViewModel
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Books = x.Books.Select(b => new AllBooksViewModel
                     {
                         Id = b.Id,
                         Title = b.Title,
                         ReleaseYear = b.ReleaseYear,
                         ImageURL = b.ImageURL,
                     }).OrderBy(x => x.Title).ToList(),
                 }).FirstOrDefault();

            return model;
        }

        public ICollection<GenreViewModel> ViewAllGenres()
        {
            var model = data.Genres
                .Select(x => new GenreViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    BooksCount = x.Books.Count(),
                }).ToList();

            return model;
        }
    }
}
