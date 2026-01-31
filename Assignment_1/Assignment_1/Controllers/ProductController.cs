using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class ProductController : Controller
    {

        public List<Product> Movies = new List<Product>();

        ProductBL productBL = new ProductBL();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProducts()
        {
            List<Product> ProductList = productBL.GetAll();
            return View("ShowAll", ProductList);
        }

        public IActionResult ShowById(int id)
        {
            Product result = productBL.ShowById(id);
            if (result != null)
            {
                return View("ShowById", productBL.ShowById(id));
            }
            return NotFound();
        }
    }
}
