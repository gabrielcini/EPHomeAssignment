using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Model;

namespace ShoppingCart.Application.Interfaces
{
    public interface IProductsService
    {
        IQueryable<ProductViewModel> GetProducts();

        //void RateProduct(Guid id, string comment, double rating);

        ProductViewModel GetProduct(Guid id);

        void AddProduct(ProductViewModel data);

        void DeleteProduct(Guid id);
    }
}
