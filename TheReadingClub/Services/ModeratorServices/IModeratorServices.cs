using System.Collections.Generic;
using TheBookClub.Models.ModeratorModels;

namespace TheBookClub.Services.ModeratorServices
{
    public interface IModeratorServices
    {
        public ICollection<AuthorsApprovalViewModel> PopulateAuthorApprovalView();

        public void ApproveAuthor(int id);

        public void DeclineAuthor(int id);

        public ICollection<BooksApprovalViewModel> PopulateBookApprovalView();

        public void ApproveBook(int id);

        public void DeclineBook(int id);
    }
}
