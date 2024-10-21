using HW_MVC_Core_11_Roles_2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop_app.Models;

namespace Shop_app.Controllers
{

    public class ProductsController : Controller
    {
        private readonly UserContext? _userContext;
        public ProductsController(UserContext ?_userContext)
        {
            _userContext = _userContext ?? throw new ArgumentNullException("Error, Context is reqired  ...");
        }
        [HttpGet]
        public IActionResult Index()
        {
            // Ваш код
            return View(ProductCollection.Products);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
        //[Authorize(Roles = "admin")]
        [HttpGet]
        public ViewResult Create() => View();
        //[Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Price,Description")] Product product)
        {
            return RedirectToAction(nameof(Index));    
        }
        //[Authorize(Roles = "admin")]
        [HttpGet]
        public ViewResult Update() => View();
        //[Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, [Bind("Id,Name,Price,Description")] Product product)
        {
            return RedirectToAction(nameof(Index));
        }
        //[Authorize(Roles = "admin")]
        [HttpGet]
        public ViewResult Delete() => View();
        //[Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
