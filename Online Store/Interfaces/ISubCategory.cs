using Online_Store.Domain.Data;

namespace Online_Store.Interfaces
{
    public interface ISubCategory
    {
        public void CreateProudct(SubCategory subCategory);
        public List<SubCategory> subCategory();

        public SubCategory GetSubCategoryyById(int id);
        public void DeleteSubCategory(int id);
        public void UpdateSubCategory(SubCategory subCategory);
    }
}
