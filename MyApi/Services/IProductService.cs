using MyApi.Models;
using System.Collections.Generic;

namespace MyApi.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();  // Returns a List<Product>
        Product GetProductById(int id);  // Returns a Product
        void AddProduct(Product product); // Takes a Product
        void UpdateProduct(int id, Product product); // Takes an int and a Product
        void DeleteProduct(int id); // Takes an int
    }
}