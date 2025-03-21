using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models;
using System.Collections.Generic;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var menuItems = new List<MenuItem>
            {
                new MenuItem("Grilled Chicken", "Delicious grilled chicken served with mashed potatoes.", 32.99m),
                new MenuItem("Pasta Primavera", "Fresh pasta with seasonal vegetables in a creamy sauce.", 12.99m),
                new MenuItem("Steak", "Juicy grilled steak with roasted vegetables.", 45.99m)
            };

            return View(menuItems);
        }
    }
}
