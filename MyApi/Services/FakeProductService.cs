using MyApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyApi.Services
{
    public class FakeProductService : IProductService
    {
        private readonly List<Product> _fakeProducts;

        public FakeProductService()
        {
            _fakeProducts = new List<Product>();  // Initialize with an empty list or mock data
        }

        public List<Product> GetAllProducts()
        {
            return _fakeProducts;
        }

        public Product GetProductById(int id)
        {
            return _fakeProducts.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            _fakeProducts.Add(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = _fakeProducts.FirstOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                // Update other properties as needed
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _fakeProducts.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _fakeProducts.Remove(product);
            }
        }
    }
}
