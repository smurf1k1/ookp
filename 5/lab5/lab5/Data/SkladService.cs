using Dapper;
using lab5.Models;
using System.Collections.Generic;

namespace lab5.Data
{
    public class SkladService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            using(var connection = DatabaseConnection.CreateConnection())
            {
                return connection.Query<Product>("SELECT * FROM Product");
            }
        }

        public void AddProduct(Product product)
        {
            using(var connection = DatabaseConnection.CreateConnection())
            {
                connection.Execute("INSERT INTO Product (Name, Price, Weight) Values(@Name, @Price, @Weight)");
            }
        }

        public IEnumerable<Product> GetByPrice(decimal price)
        {
            using(var connection = DatabaseConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM Product WHERE Price = {price}";
                return connection.Query<Product>(sql);
            }
        }
    }
}
