﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheReadingClub.Data.DBModels;

namespace TheReadingClub.Data
{
    public class TheReadingClubDbContext : IdentityDbContext<User>
    {
        public TheReadingClubDbContext(DbContextOptions<TheReadingClubDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Story> Stories { get; set; }

        public DbSet<AuthorPendingApproval> AuthorPendingApprovals { get; set; }

        public DbSet<BookPendingApproval> BookPendingApprovals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
