using System.Collections.Generic;
using TheBookClub.Models.BookViewModels;
using TheBookClub.Models.GenreModels;

namespace TheBookClub.Services.GenreServices
{
    public interface IGenreServices
    {
        public ICollection<GenreViewModel> ViewAllGenres ();

        public GenreByIdViewModel GenreByIdView(int id); 
    }
}
