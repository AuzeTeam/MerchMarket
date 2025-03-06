
using backend_csh.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_csh.Controllers
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
        public async Task<IEnumerable<Product>> Get()
        {
            return await _dbContext.Products.ToListAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product?> Get(Guid id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<Product> Post([FromBody] Product value)
        {
            value.Id = new Guid();
            _dbContext.Products.Add(value);
            await _dbContext.SaveChangesAsync();
            
            return value;
        }

        // PUT api/<ProductController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Product vProduct)
        {
            var existingProduct = await _dbContext.Products.FindAsync(vProduct.Id);
    
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
        [HttpDelete("/{id}")]
        public async Task Delete(Guid id)
        {
            await _dbContext.Products.Where(x => x.Id == id).ExecuteDeleteAsync();

        }
    }
}
