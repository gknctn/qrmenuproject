using Entities.Dtos;
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
        public ActionResult Deneme()
        {
            return View();
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
        public async Task<ActionResult> ProductCreateAsync([FromForm] ProductDtoForInsertion productDto, IFormFile? file)
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
                    productDto.ProductImage = String.Concat("/MenuProductImageFiles/", file.FileName);
                }
                else
                {
                    productDto.ProductImage = "/MenuProductImageFiles/defaultProductPicture.jpg";
                }
                _manager.ProductService.AddProduct(productDto, true);

                return RedirectToAction("Index");
            }
            else
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
            ProductDtoForUpdate value = _manager.ProductService.GetOneProductForUpdate(id, false);

            return View(value);
        }

        // POST: AdminProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ProductEditAsync([FromForm] ProductDtoForUpdate productDtoForUpdate, IFormFile? file)
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
                        productDtoForUpdate.ProductImage = String.Concat("/MenuProductImageFiles/", file.FileName);
                    }
                    _manager.ProductService.EditProduct(productDtoForUpdate, true);
                    return RedirectToAction("Index");
                }
                List<SelectListItem> categoryValues = (from x in _manager.CategoryService.GetAllCategories(false)
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.CategoryId.ToString(),
                                                       }).ToList();
                ViewBag.Categorylist = categoryValues;
                
                return View(productDtoForUpdate);
            }
            catch
            {
                return View(productDtoForUpdate);
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
