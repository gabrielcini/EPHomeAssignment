using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class OrdersController : Controller
    {
        [HttpPost]
        public IActionResult Checkout()
        {
            string emailLoggedIn = User.Identity.Name;

            return View();
        }
    }
}
