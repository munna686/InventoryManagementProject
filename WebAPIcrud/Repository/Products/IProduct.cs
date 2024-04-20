using Microsoft.AspNetCore.Mvc;
using WebAPIcrud.Models;

namespace WebAPIcrud.Repository.Products
{
    public interface IProduct
    {
        Task<ActionResult<List<Product>>> GetProducts();
        Task<ActionResult<Product>> GetProductById(int id);
        Task<ActionResult<Product>> CreateProduct(Product product);
        Task<ActionResult<Product>> UpdateProduct(int id,Product product);
        Task<ActionResult<Product>> DeleteProduct(int id);
    }
}
