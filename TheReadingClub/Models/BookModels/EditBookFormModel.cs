using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheBookClub.Models.AuthorModels;
using TheBookClub.Models.BookViewModels;
using static TheBookClub.ProjectConstants;

namespace TheBookClub.Models.BookModels
{
    public class EditBookFormModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [RegularExpression(BookTitleRegex)]
        [StringLength(BookTitleMaxLenght, MinimumLength = BookTitleMinLenght)]
        public string Title { get; set; }
        
        [Display(Name = "Full Name")]
        public ICollection<AuthorBookSelectFormModel> Author { get; set; }

        [Display(Name = "Full Name")]
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Discription")]
        [StringLength(BookDescriptionMaxLenght, MinimumLength = BookDescriptionMinLenght)]
        public string Description { get; set; }

        [Required]
        [Url]
        public string ImageURL { get; set; }

        [Required]
        [RegularExpression(BookYearRegex)]
        public int ReleaseYear { get; set; }

        [Display(Name = "Genres selection")]
        public ICollection<int> GenresId { get; set; }

        [Display(Name = "Genres selection")]
        public ICollection<GenreViewModel> Genres { get; set; }
    }
}
