using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIcrud.Models;

namespace WebAPIcrud.Repository.Categories
{
    public class CategoryRepo : ICategory
    {
        private readonly InventoryManagmentContext _context;
        public CategoryRepo(InventoryManagmentContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var data = _context.Categories.Find(id);
            _context.Categories.Remove(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var data = await _context.Categories.FindAsync(id);
            return data;
        }

        public async Task<ActionResult<Category>> UpdateCategory(int id, Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
