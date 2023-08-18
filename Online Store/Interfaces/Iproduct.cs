using Online_Store.Domain.Data;

namespace Online_Store.Interfaces
{
    public interface IProduct
    {
      public void CreateProudct(Product product);
      public List<Product> Products() ;
      
      public Product GetProductById(int id) ;
      public void DeleteProduct(int id) ;
      public void UpdateProduct(Product product) ;
     

    }
}
