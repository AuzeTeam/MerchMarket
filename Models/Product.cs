using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Product
    {
        [Key]
        public required Guid ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        // public List<IFormFile> Image { get; set; }
        public ICollection<Image> Image { get; set; } = new List<Image>();
    }
}
