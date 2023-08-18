using Online_Store.Domain.Data;
using Online_Store.Models.Category;

namespace Online_Store.Interfaces
{
    public interface ICategory
    {
        public void CreateCategory(CreateCategory category);
        public List<Category> GetAllcategory();

        public Category GetcategoryById(int id);
        public void DeleteCategory(int id);
        public void UpdateCategory(Category category);
    }
}
