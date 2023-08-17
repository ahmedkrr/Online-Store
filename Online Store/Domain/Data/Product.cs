using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Online_Store.Domain.Data
{
    public class Product
    {
        public int ProudctId { get; set; }
        public string ProudctName { get; set; } = null!;
        public int ProudctAmount { get; set; }

        public SubCategory SubCategory { get; set; } = null!;
        public int SubcategoryId { get; set; }


    }
}
