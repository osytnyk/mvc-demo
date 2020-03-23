using MvcTest2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcTest2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IReadOnlyCollection<Product> _products = new List<Product>
        {
	        new Product{Id = 1, Name = "Phone"},
	        new Product{Id = 2, Name = "Headphones"},
	        new Product{Id = 3, Name = "Tablet"}
        };

        // GET: Product
        public ActionResult Index()
        {
            return View(_products);
        }

        // GET: Product/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
	        if (_products.All(x => x.Id != id))
	        {
		        return RedirectToAction("Index");
            }
	        var product = _products.First(x => x.Id == id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
