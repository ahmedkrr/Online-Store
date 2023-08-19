using Online_Store.Domain.Data;
using Online_Store.Models.Category;
using Online_Store.Models.Customer;

namespace Online_Store.Interfaces
{
    public interface ICustomer
    {
        public void CreateCustomer(CreateCustomer customer);
        public List<Customer> GetAllcategory();

        public Customer GetCustomerById(int id);
        
        public void UpdateCustomer(Customer customer);
    }
}
