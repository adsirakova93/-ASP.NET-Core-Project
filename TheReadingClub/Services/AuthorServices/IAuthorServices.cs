using System.Collections.Generic;
using TheBookClub.Models.AuthorModels;
using TheBookClub.Models.AuthorViewModels;

namespace TheBookClub.Services.FormModelServices
{
    public interface IAuthorServices
    {
        public bool AddAuthorToBeApproved(AddAuthorFormModel author);

        public ICollection<AuthorsViewModel> PopulateAuthorsViewModel(string id);

        public AuthorViewModel PopulateAuthorViewModel(int id);

        public EditAuthorFormModel GetAuthorFromDb(int id);

        public bool EditAuthor(EditAuthorFormModel model);
    }
}
