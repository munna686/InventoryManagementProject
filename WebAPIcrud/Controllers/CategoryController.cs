using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIcrud.Models;
using WebAPIcrud.Repository.Categories;

namespace WebAPIcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            return await _category.GetCategories();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            var data = await _category.GetCategoryById(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category category)
        {
            await _category.CreateCategory(category);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Category>> Update(int id,Category category)
        {
            return await _category.UpdateCategory(id, category);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> Delete(int id)
        {
            return await _category.DeleteCategory(id);
        }
    }
}
