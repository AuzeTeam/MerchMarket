using System.ComponentModel.DataAnnotations;

namespace backend_csh
{
    public class Product
    {
        [Key]
        public required Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
