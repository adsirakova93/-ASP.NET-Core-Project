using System.Collections.Generic;
using System.Linq;
using TheBookClub.Data.DBModels;

namespace TheBookClub.Tests.Data
{
    public static class Books
    {
        public static IEnumerable<Book> TenBooks
            => Enumerable.Range(0, 10).Select(i => new Book { });
    }

    public static class Authors
    {
        public static IEnumerable<Author> TenAuthors
           => Enumerable.Range(0, 10).Select(i => new Author { });
    }

    public static class Genres
    { 
        public static IEnumerable<Genre> TenGenres
           => Enumerable.Range(0, 10).Select(i => new Genre { });
    }
}
