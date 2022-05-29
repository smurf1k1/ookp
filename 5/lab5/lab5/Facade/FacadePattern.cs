using lab5.Data;
using lab5.Models;
using System.Collections.Generic;

namespace lab5.Facade
{
    public class FacadePattern
    {
        private readonly SkladService _service;

        public FacadePattern()
        {
            _service = new SkladService();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _service.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
            _service.AddProduct(product);
        }

        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return _service.GetByPrice(price);
        }
    }
}
