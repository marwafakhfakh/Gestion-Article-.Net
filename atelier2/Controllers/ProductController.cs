using atelier2.Models.Repositories;
using atelier2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace atelier2.Controllers
{
    public class ProductController : Controller
    {
        readonly IRepository<Product> ProductRepository;
        
        public ProductController(IRepository<Product> ProdRepository)
        {
            ProductRepository = ProdRepository;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var Products = ProductRepository.GetAll();
            return View(Products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var Products = ProductRepository.FindByID(id);
            return View(Products);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            var Products = ProductRepository.GetAll;
            return View(Products);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var Products = ProductRepository.FindByID;
            return View(Products);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var Products = ProductRepository.FindByID;
            return View(Products);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
