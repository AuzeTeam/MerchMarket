using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public required byte[] ImageData { get; set; }
        public string? ImageName { get; internal init; }
        
        public Guid ProductId { get; set; }
        
        public Product? Product { get; set; }
    }
}
