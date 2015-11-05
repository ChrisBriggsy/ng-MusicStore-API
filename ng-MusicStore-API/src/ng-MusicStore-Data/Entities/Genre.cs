﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ng_MusicStore_Data.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Album> Albums { get; set; }
    }
}