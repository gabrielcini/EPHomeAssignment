using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Application.ViewModels;

namespace ShoppingCart.Application.Interfaces
{
    public interface ICategoriesService
    {
        IQueryable<CategoryViewModel> GetCategories();
    }
}
