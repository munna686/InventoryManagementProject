using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIcrud.Models;
using WebAPIcrud.Repository.Products;

namespace WebAPIcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
           return await _product.GetProducts();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var data = await _product.GetProductById(id);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            await _product.CreateProduct(product);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id,Product product)
        {
            if(id != product.ProductId)
            {
                return BadRequest();
            }
            return await _product.UpdateProduct(id, product);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            return await _product.DeleteProduct(id);
        }
    }
}
