using L06_Northwind_DB.Context;
using L06_Northwind_DB.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private NorthwindDbContext _context;
        public ProductController(NorthwindDbContext dbContext)
        {
            _context = dbContext;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get([FromQuery] int? page)
        {
            var products = _context.Products
                    .Include(p => p.Category)
                    .Where(p => p.UnitsInStock > 0 && p.Discontinued != "1")
                    .OrderBy(p => p.ProductID)
                    .Skip((page ?? 1) * 20)
                    .Take(20)
                    ;

            return Ok(products);
        }
        
        [HttpGet("outofstock")]
        public IActionResult GetOutOfStock()
        {
            var products = _context.Products
                    .Include(p => p.Category)
                    .Where(p => p.UnitsInStock == 0 && p.Discontinued != "1")
                    .OrderBy(p => p.ProductID)
                    .Take(20);

            return Ok(products);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return Ok($"api/Product/{product.ProductID}");
        }

        
    }
}
