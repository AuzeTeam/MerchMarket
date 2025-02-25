using Microsoft.AspNetCore.Mvc;

namespace backend_csh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static List<Product> pd = new List<Product>();

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(pd);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IEnumerable<Product> Get(long id)
        {
            yield return pd.First(p => p.Id == id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            var newId = new Random().Next(1, 9999);
            value.Id = newId;
            pd.Add(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product valueUpdate)
        {
            if (valueUpdate.Id != id) BadRequest();

            var prod = pd.FirstOrDefault(p => p.Id == id);

            if (prod == null) BadRequest();

            prod.Name = valueUpdate.Name;
            prod.Description = valueUpdate.Description;
            prod.Price = valueUpdate.Price;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var prod = pd.FirstOrDefault(p => p.Id == id);
            pd.Remove(prod);
        }
    }
}
