using Book_Store.Data;
using Book_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Book_Store.Controllers
{
    public class OrderController : Controller
    {
        protected ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Order_Book(int book, string name_customer, int quantity)
        {
            var order = new Order
            {
                BookId = book,
                Customer = name_customer,
                Quantity = quantity
            };
            context.Orders.Add(order);
            context.SaveChanges();
            return View();
        }
        public IActionResult List()
        {
            return View(context.Orders.ToList());
        }
        /*[HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Order order)
        {
            return RedirectToAction("Index", order);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Update(order);
            return RedirectToAction("Index", order);
        }
        public IActionResult Delete(int id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);
            return RedirectToAction("Index", order);
        }*/
    }
}
