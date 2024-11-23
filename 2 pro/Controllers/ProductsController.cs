using _2_pro.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2_pro.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.products.ToList();
            return View(products);
        }
    }
}
