using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBookClub.Data;
using TheBookClub.Data.DBModels;
using TheBookClub.Models.AdminModels;
using static TheBookClub.ProjectConstants;

namespace TheBookClub.Services.AdminServices
{
    public class AdminServices : IAdminServices
    {
        private readonly TheBookClubDbContext data;
        private readonly UserManager<User> userManager;

        public AdminServices(
            TheBookClubDbContext data,
            UserManager<User> userManager)
        {
            this.data = data;
            this.userManager = userManager;
        }

        public ICollection<AllUsersViewModel> AllUsers(string id)
        {
            var users = data.Users
                .Where(x=> x.FullName.StartsWith(id))
                .Select(x => new AllUsersViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Email = x.Email,
                })
                .OrderBy(x=> x.FullName)
                .ToList();

            return users;
        }

        public bool PromoteUserToModerator(string id)
        {
            var user = data.Users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null)
            {
                return false;
            }

            Task.Run(async () => await userManager.AddToRoleAsync(user, ModeratorRole))
                .GetAwaiter()
                .GetResult();

            return true;
        }

        public UserByIdViewModel UserById(string id)
        {
            var user = data.Users
                .Where(x => x.Id == id)
                .Select(x => new UserByIdViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Email = x.Email,
                }).FirstOrDefault();

            return user;
        }
    }
}
