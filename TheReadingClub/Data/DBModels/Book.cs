﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static TheBookClub.ProjectConstants;

namespace TheBookClub.Data.DBModels
{
    public class Book
    {
        public Book()
        {
            this.Genres = new HashSet<Genre>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(BookTitleMaxLenght)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public ICollection<Genre> Genres { get; set; }

        [Required]
        [MaxLength(BookDescriptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public int ReleaseYear { get; set; }
    }
}
