using Assignment_2.Models;
using Assignment_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _db = new AppDbContext();

        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();
                //.Include(p => p.Category)
                //.ToList();

            ViewBag.msg = TempData["msg"];
            return View("Index", products);
        }

        public IActionResult Add()
        {
            ProductViewModel vm = new ProductViewModel();
            vm.Product = new Product();
            vm.Categories = _db.Categories.ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddSave(ProductViewModel vm)
        {
            _db.Products.Add(vm.Product);
            _db.SaveChanges();
            TempData["msg"] = "Product Added Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ProductViewModel vm = new ProductViewModel();
            vm.Product = _db.Products.Find(id);
            vm.Categories = _db.Categories.ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult EditSave(ProductViewModel vm)
        {
            _db.Products.Update(vm.Product);
            _db.SaveChanges();
            TempData["msg"] = "Product Updated Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product prod = _db.Products.Find(id);
            _db.Products.Remove(prod);
            _db.SaveChanges();
            TempData["msg"] = "Product Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
