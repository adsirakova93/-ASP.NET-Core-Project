﻿using System.Collections.Generic;

namespace TheBookClub.Models.AuthorModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string ImageURL { get; set; }

        public ICollection<AuthorBookViewModel> Books { get; set; }
    }
}
