using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;

namespace Online_Store.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product )
        {
            _product.CreateProudct(product);    
            return View();
        }
    }
}
