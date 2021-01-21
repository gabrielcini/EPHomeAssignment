using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Application.ViewModels;

namespace Presentation.Models
{
    public class CreateProductModel
    {
        public List<CategoryViewModel> Categories { get; set; }
        public ProductViewModel Product { get; set; }
    }

    public class ListProductModel
    {
        public List<CategoryViewModel> Categories { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
