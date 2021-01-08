using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

namespace Presentation.Controllers
{
  //[Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private IProductsService _productsService;
        private ICategoriesService _categoriesService;
        private IWebHostEnvironment _env;
        public ProductsController(IProductsService productsService, ICategoriesService categoriesService, IWebHostEnvironment env)
        {
            _productsService = productsService;
            _categoriesService = categoriesService;
            _env = env;
        }
        /// <summary>
        /// Products Catalogue
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var list = _productsService.GetProducts();
            return View(list);
        }
        public IActionResult Details(Guid id)
        {
            var myProduct = _productsService.GetProduct(id);

            return View(myProduct);
        }
        [HttpGet] //the get method which will load with blank fields
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var catList = _categoriesService.GetCategories();

            //ViewBag.Categories = catList;

            CreateProductModel model = new CreateProductModel();
            model.Categories = catList.ToList();

            return View(model); //model => ProductViewModel
        }
        [HttpPost] //the post method is called when the user clicks on the submit button
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateProductModel data, IFormFile file)
        {
            //validation
            try
            {
                if(file != null)
                {
                    if(file.Length > 0)
                    {
                        string newFilename = Guid.NewGuid() + System.IO.Path.GetExtension(file.FileName);
                        //D:\Documents\MCAST\2ndYear\1stSemester\EnterpriseProgramming\SWD62AEP\SWD62AEP\Presentation\wwwroot\
                        string absolutePath = _env.WebRootPath + @"\Images\";
                        
                        using (var stream = System.IO.File.Create(absolutePath + newFilename))
                        {
                            file.CopyTo(stream);
                        }

                        data.Product.ImageUrl = @"\Images\" + newFilename; //relativePath
                    }
                }

                _productsService.AddProduct(data.Product);

                ViewData["feedback"] = "Product was added successfully";
                ModelState.Clear();
            }
            catch(Exception ex)
            {
                ViewData["warning"] = "Product was not added. Check your details";
            }

            CreateProductModel model = new CreateProductModel();
            model.Categories = _categoriesService.GetCategories().ToList();

            return View(model);
        }
        public IActionResult Delete(Guid id)
        {
            _productsService.DeleteProduct(id);
            TempData["feedback"] = "Product was deleted successfully"; //TempData
            return RedirectToAction("Index");
        }
    }
}
