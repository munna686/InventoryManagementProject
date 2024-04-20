using Microsoft.AspNetCore.Mvc;
using WebAPIcrud.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIcrud.Repository.Products
{
    public class ProductRepo : IProduct
    {
        private readonly InventoryManagmentContext _context;
        public ProductRepo(InventoryManagmentContext context)
        {
            _context = context;
        }
        

        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var data = await _context.Products.FindAsync(id);
            return data;
        }
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var data = _context.Products.Find(id);
            _context.Products.Remove(data);
            await _context.SaveChangesAsync();
            return data;
        }

    }
}
