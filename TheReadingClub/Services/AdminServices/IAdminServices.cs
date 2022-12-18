using System.Collections.Generic;
using TheBookClub.Models.AdminModels;

namespace TheBookClub.Services.AdminServices
{
    public interface IAdminServices
    {
        public ICollection<AllUsersViewModel> AllUsers(string id);

        public UserByIdViewModel UserById(string id);

        public bool PromoteUserToModerator(string id);
    }
}
