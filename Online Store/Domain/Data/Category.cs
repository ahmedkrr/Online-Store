namespace Online_Store.Domain.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public List<SubCategory> SubCategories { get; set; } = null!;


    }
}
