using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Model;
using System.Linq;

namespace ShoppingCart.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        IQueryable<Category> GetCategories();
    }
}
