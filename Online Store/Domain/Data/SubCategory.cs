namespace Online_Store.Domain.Data
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public int CategoryId { get; set; }
        public List<Product> products { get; set; } = null!;


    }
}
