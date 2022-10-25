using _1670BookStore.Data;
using _1670BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _1670BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;
        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Categories.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                var category = context.Categories.Find(id);
                return View(category);
            }
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }
        public IActionResult Delete(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                var category = context.Categories.Find(id);
                context.Categories.Remove(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
