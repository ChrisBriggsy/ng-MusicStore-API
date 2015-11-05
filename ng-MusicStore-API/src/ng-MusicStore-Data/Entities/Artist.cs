using System.ComponentModel.DataAnnotations;

namespace ng_MusicStore_Data.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}