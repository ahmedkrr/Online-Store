using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Interfaces;
using Online_Store.Models.Category;
using Online_Store.Services;

namespace Online_Store.Controllers
{
    public class Category : Controller
    {
        private readonly ICategory _category;
        public Category(ICategory category )
        {
            _category = category;   
        }

        public IActionResult Index()
        {
          var categories=  _category.GetAllcategory();

            return View(categories);

        }

        public IActionResult AddCategory() 
        { 

            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CreateCategory category)
        {

            _category.CreateCategory(category);
            return View();
        }
    }
}
