using System.Collections.Generic;
using System.Linq;
using TheBookClub.Data;
using TheBookClub.Models.AuthorModels;
using TheBookClub.Models.AuthorViewModels;

namespace TheBookClub.Services.FormModelServices
{
    public class AuthorServices : IAuthorServices
    {
        private readonly TheBookClubDbContext data;

        public AuthorServices(TheBookClubDbContext data)
        {
            this.data = data;
        }

        public bool AddAuthorToBeApproved(AddAuthorFormModel author)
        {
            var authorToAdd = new Data.DBModels.AuthorPendingApproval
            {
                FullName = author.FullName,
                ImageURL = author.ImageURL,
            };

            data.AuthorPendingApprovals.Add(authorToAdd);
            data.SaveChanges();
            return true;
        }

        public bool EditAuthor(EditAuthorFormModel model)
        {
            var author = data.Authors.Where(x => x.Id == model.Id).FirstOrDefault();

            if (author != null)
            {
                var toBeApproved = new Data.DBModels.AuthorPendingApproval
                {FullName = author.FullName, ImageURL= author.ImageURL };
                data.AuthorPendingApprovals.Add(toBeApproved);
                data.SaveChanges();
                return true;
            }

            return false;
        }

        public EditAuthorFormModel GetAuthorFromDb(int id)
        {
            var model = data.Authors
                .Where(x => x.Id == id)
                .Select(x => new EditAuthorFormModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    ImageURL = x.ImageURL,
                }).FirstOrDefault();

            return model;
        }

        public ICollection<AuthorsViewModel> PopulateAuthorsViewModel(string id)
        {
            var authors = data.Authors
            .Where(x => x.FullName.StartsWith(id))
            .Select(x => new AuthorsViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Books = x.Books.Count(),
            })
            .OrderBy(n=> n.FullName)
            .ToList();

            return authors;
        }

        public AuthorViewModel PopulateAuthorViewModel(int id)
    {
        var author = data.Authors.Where(x => x.Id == id)
            .Select(x => new AuthorViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                ImageURL = x.ImageURL,
                Books = x.Books.Select(b => new AuthorBookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Genre = b.Genres.Select(g => g.Name).ToList(),
                }).OrderBy(n => n.Title).ToList(),
            }
            ).FirstOrDefault();

        return author;
    }
}
}
