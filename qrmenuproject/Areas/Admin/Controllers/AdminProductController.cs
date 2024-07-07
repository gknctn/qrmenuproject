using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        // GET: AdminProductController
        public ActionResult Index()
        {
            var values = _manager.ProductService.GetAllProductsWithCategory(false);
            return View(values);
        }

        // GET: AdminProductController/Details/5
        public ActionResult ProductDetail([FromRoute] int id)
        {
            Product value = _manager.ProductService.GetOneProduct(id, false);
            return View(value);
        }

        // GET: AdminProductController/Create
        public ActionResult ProductCreate()
        {
            List<SelectListItem> categoryValues = (from x in _manager.CategoryService.GetAllCategories(false)
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString(),
                                                   }).ToList();
            ViewBag.Categorylist = categoryValues;
            return View();
        }

        // POST: AdminProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ProductCreateAsync([FromForm] Product product, IFormFile? file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MenuProductImageFiles", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    product.ProductImage = String.Concat("/MenuProductImageFiles/", file.FileName);
                }
                else
                {
                    product.ProductImage = "/MenuProductImageFiles/defaultProductPicture.jpg";
                    
                }

                List<SelectListItem> categoryValues = (from x in _manager.CategoryService.GetAllCategories(false)
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.CategoryId.ToString(),
                                                       }).ToList();

                ViewBag.Categorylist = categoryValues;
                _manager.ProductService.AddProduct(product, true);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminProductController/Edit/5
        [HttpGet]
        public ActionResult ProductEdit([FromRoute] int id)
        {
            List<SelectListItem> categoryValues = (from x in _manager.CategoryService.GetAllCategories(false)
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString(),
                                                   }).ToList();
            ViewBag.Categorylist = categoryValues;
            Product value = _manager.ProductService.GetOneProduct(id, false);
            return View(value);
        }

        // POST: AdminProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ProductEditAsync([FromForm] Product product,IFormFile? file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file is not null)
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MenuProductImageFiles", file.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        product.ProductImage = String.Concat("/MenuProductImageFiles/", file.FileName);
                    }
                    _manager.ProductService.EditProduct(product, true);
                    return RedirectToAction("Index");
                }
                List<SelectListItem> categoryValues = (from x in _manager.CategoryService.GetAllCategories(false)
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.CategoryId.ToString(),
                                                       }).ToList();
                ViewBag.Categorylist = categoryValues;
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminProductController/Delete/5
        [HttpGet]
        public ActionResult ProductDelete([FromRoute] int id)
        {
            Product value = _manager.ProductService.GetOneProduct(id, false);
            return View(value);
        }
        [HttpPost]
        public ActionResult ProductDelete([FromForm] Product product)
        {
            _manager.ProductService.DeleteProduct(product, true);
            return RedirectToAction("Index");
        }
    }
}
