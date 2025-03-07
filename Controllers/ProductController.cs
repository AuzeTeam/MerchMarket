
using backend.Database;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var allProd = await _dbContext.Products
                .Include(e => e.Image)
                .ToListAsync();
            var productResponses = allProd.Select(product => new Product
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image.Select(img => new Image
                {
                    ImageData = img.ImageData
                }).ToList()
            }).ToList();
            
            return productResponses;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _dbContext.Products
                .Include(p => p.Image)
                .FirstAsync(p => p.ProductId == id);

            var productResponse = new Product
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image.Select(img => new Image
                {
                    
                    ImageName = img.ImageName,
                    ImageData = img.ImageData,
                    
                }).ToList()
            };

            return Ok(productResponse);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm]Product dto, IFormFile[] files)
        {
            var newProduct = new Product 
            {
                ProductId = Guid.NewGuid(),
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
            };
            foreach (var file in files)
            {
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream);
                var imageEntity = new Image
                {
                    // ImageId = Guid.NewGuid(),
                    ImageData = memoryStream.ToArray(),
                    ImageName = file.FileName,
                    // ProductId = newProduct.ProductId
                };
                newProduct.Image.Add(imageEntity);
            }
            
            _dbContext.Products.Add(newProduct);
            await _dbContext.SaveChangesAsync();

            return Ok("Created product");
        }
        // PUT api/<ProductController>
        [HttpPut]
        public async Task<IActionResult> PutProductById([FromBody] Product vProduct)
        {
            var existingProduct = await _dbContext.Products.FindAsync(vProduct.ProductId);
    
            if (existingProduct == null)
            {
                return NotFound();
            }

            _dbContext.Entry(existingProduct).CurrentValues.SetValues(vProduct);

            try
            {
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task DeleteProduct(Guid id)
        {
            await _dbContext.Products.Where(x => x.ProductId == id).ExecuteDeleteAsync();

        }

    }
}
