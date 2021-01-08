using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Domain.Interfaces
{
    public interface IProductsRepository
    {
        IQueryable<Product> GetProducts();

        Product GetProduct(Guid id);
        void AddProduct(Product p);
        void DeleteProduct(Guid id);
    }
}
