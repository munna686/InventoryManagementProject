using Microsoft.AspNetCore.Mvc;
using WebAPIcrud.Models;

namespace WebAPIcrud.Repository.Categories
{
    public interface ICategory
    {
        Task<ActionResult<List<Category>>> GetCategories();
        Task<ActionResult<Category>> GetCategoryById(int id);
        Task<ActionResult<Category>> CreateCategory(Category product);
        Task<ActionResult<Category>> UpdateCategory(int id, Category category);
        Task<ActionResult<Category>> DeleteCategory(int id);
    }
}
