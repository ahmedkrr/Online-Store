using Online_Store.Domain;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;

namespace Online_Store.Services
{
    public class ProductServices : IProduct
    {

        private readonly ApplicationDbContext _context;
        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
            
        }

        public void CreateProudct(Product product)
        {
            _context.Add<Product>(product); 
            _context.SaveChanges();

        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Products()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
