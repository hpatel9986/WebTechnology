using System.ComponentModel.DataAnnotations;

namespace MovieApp_API.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "Title must start with a capital letter")]
        public string Title { get; set; }

        [Range(1900, 2025)]
        public int ReleaseYear { get; set; }

        [Required]
        [RegularExpression(@"^(Action|Comedy|Drama|Horror|SciFi)$")]
        public string Genre { get; set; }

        [Display(Name = "Image URL")]
        public string ImgUrl { get; set; }
    }
}