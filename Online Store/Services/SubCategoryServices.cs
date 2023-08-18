using Online_Store.Domain;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;

namespace Online_Store.Services
{
    public class SubCategoryServices : ISubCategory
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public  void  CreateSubCategory(SubCategory subCategory)
        {
            var category  = _context.Set<Category>().FirstOrDefault(c => c.CategoryId == subCategory.CategoryId);
            if(category != null)
            {
                var sub = new SubCategory()
                {
                    SubCategoryName = subCategory.SubCategoryName,
                    CategoryId =subCategory.CategoryId

                };
                _context.Add(sub);
                _context.SaveChanges();

            }


        }

        public void DeleteSubCategory(int id)
        {
            throw new NotImplementedException();
        }

        public SubCategory GetSubCategoryyById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> subCategory()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }
    }
}
