using System.Collections.Generic;
using TheBookClub.Models.BookModels;

namespace TheBookClub.Models.GenreModels
{
    public class GenreByIdViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AllBooksViewModel> Books { get; set; }
    }
}
