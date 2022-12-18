﻿using System.Collections.Generic;

namespace TheBookClub.Models.AuthorModels
{
    public class AuthorBookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<string> Genre { get; set; }
    }
}
