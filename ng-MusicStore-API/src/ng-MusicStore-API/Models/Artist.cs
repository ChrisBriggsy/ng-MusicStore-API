﻿using System.ComponentModel.DataAnnotations;

namespace ng_MusicStore_API.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}