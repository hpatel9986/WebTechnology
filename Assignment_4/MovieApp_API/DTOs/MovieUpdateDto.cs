using System.ComponentModel.DataAnnotations;

namespace MovieApp_API.DTOs
{
    public class MovieUpdateDto
    {
        [Required]
        [RegularExpression(@"^[A-Z].*")]
        public string Title { get; set; }

        [Range(1900, 2025)]
        public int ReleaseYear { get; set; }

        [RegularExpression("^(Action|Comedy|Drama|Horror|SciFi)$")]
        public string Genre { get; set; }

        [Display(Name = "Image URL")]
        public string ImgUrl { get; set; }
    }
}