using Microsoft.AspNetCore.Identity;

namespace Online_Store.Domain.Data
{
    public class User 
    {
        public string UserId { get; set; }
        public List<Order> Orders { get; set; } = null!;
    }
}
