using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;

namespace Online_Store.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategory _subCategory;
        public SubCategoryController(ISubCategory subCategory)
        {
            _subCategory = subCategory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateSubCategory()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateSubCategory(SubCategory subCategory)
        {
            _subCategory.CreateSubCategory(subCategory);

            return View();
        }

    }
}
