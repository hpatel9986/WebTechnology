using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public List<Product>? Products { get; set; }
    }
}
