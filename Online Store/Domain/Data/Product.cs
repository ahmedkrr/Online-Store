using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection.Metadata.Ecma335;

namespace Online_Store.Domain.Data
{
    public class Product
    {
        public int ProudctId { get; set; }
        public string ProudctName { get; set; } = null!;
        public int ProudctAmount { get; set; }
        public string Discription { get; set; }
        public string Photo { get; set; }
        public SubCategory SubCategory { get; set; } = null!;
        public int SubcategoryId { get; set; }


    }
}
