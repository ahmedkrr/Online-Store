using Online_Store.Domain;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;
using Online_Store.Models.Category;

namespace Online_Store.Services
{
    public class CategoryServices : ICategory
    {
        private readonly ApplicationDbContext _context;
        public CategoryServices(ApplicationDbContext context)
        {
            _context = context;

        }

        public void CreateCategory(CreateCategory category)
        {
            var cat = new Category { CategoryName = category.name };
            _context.Add(cat);
            _context.SaveChanges();


        }

        public  List<Category> GetAllcategory()
        {
             var categories = _context.Set<Category>().ToList();

            return categories;

        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetcategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        
    }
}
