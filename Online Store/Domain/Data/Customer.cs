using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Data
{
    public class Customer
    {
        public int Id { set; get; }
        public string CustomerName { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        
    }
}
