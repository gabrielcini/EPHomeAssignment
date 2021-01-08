using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Models;
using System.Linq;

namespace ShoppingCart.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        IQueryable<Category> GetCategories();
    }
}
