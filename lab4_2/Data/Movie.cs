using System.ComponentModel.DataAnnotations;

namespace lab4_2.Data
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 10)]
        public float? Rate { get; set; }

        public string? ImageUrl { get; set; }

        [Display(Name = "YouTube Trailer ID")]
        [StringLength(11, ErrorMessage = "YouTube ID must be 11 characters")]
        public string? YouTubeTrailerId { get; set; }
    }

}
