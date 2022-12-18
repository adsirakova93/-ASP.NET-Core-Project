using System.ComponentModel.DataAnnotations;
using static TheBookClub.ProjectConstants;

namespace TheBookClub.Data.DBModels
{
    public class AuthorPendingApproval
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AuthorNameMaxLenght)]
        public string FullName { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}
