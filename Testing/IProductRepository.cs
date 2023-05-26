using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public Product UpdateProduct(Product product);
    }
}
