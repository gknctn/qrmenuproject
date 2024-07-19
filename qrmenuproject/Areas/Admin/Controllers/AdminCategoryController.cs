using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminCategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        // GET: AdminCategoryController
        public ActionResult Index()
        {
            IQueryable<Category> values = _manager.CategoryService.GetAllCategories(false);
            return View(values);
        }

        // GET: AdminCategoryController/Create
        public ActionResult CategoryCreate()
        {
            return View();
        }

        // POST: AdminCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoryCreate([FromForm] Category category)
        {
            try
            {
                if (ModelState.IsValid is true)
                {
                    _manager.CategoryService.AddCategory(category, false);
                    return RedirectToAction("Index");
                }
                else 
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCategoryController/Edit/5
        public ActionResult CategoryEdit([FromRoute] int id)
        {
            Category value = _manager.CategoryService.GetOneCategory(id, false);
            return View(value);
        }

        // POST: AdminCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoryEdit([FromForm] Category category)
        {
            try
            {
                if (ModelState.IsValid is true)
                {
                    _manager.CategoryService.EditCategory(category, false);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCategoryController/Delete/5
        public ActionResult CategoryDelete(int id)
        {
            Category value = _manager.CategoryService.GetOneCategory(id, false);
            return View(value);
        }

        // POST: AdminCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoryDelete(int id, Category category)
        {
            try
            {
                Category value = _manager.CategoryService.GetOneCategory(id, false);
                _manager.CategoryService.DeleteCategory(value, false);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
