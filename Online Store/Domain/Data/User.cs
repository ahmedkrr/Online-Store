using Microsoft.AspNetCore.Identity;

namespace Online_Store.Domain.Data
{
    public class User : IdentityUser
    {
        public List<Order> Orders { get; set; } = null!;


    }
}
