using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    public class CategoryController : Controller
    {
        AppDbContext _db = new AppDbContext();

        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            ViewBag.msg = TempData["msg"];
            return View("Index", categories);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSave(Category FormCategory)
        {
            if (FormCategory.CategoryName == null)
                return View("Add", FormCategory);

            _db.Categories.Add(FormCategory);
            _db.SaveChanges();
            TempData["msg"] = "Category Added Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Category cat = _db.Categories.Find(id);
            return View(cat);
        }

        [HttpPost]
        public IActionResult EditSave(Category FormCategory)
        {
            _db.Categories.Update(FormCategory);
            _db.SaveChanges();
            TempData["msg"] = "Category Updated Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Category cat = _db.Categories.Find(id);
            _db.Categories.Remove(cat);
            _db.SaveChanges();
            TempData["msg"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
