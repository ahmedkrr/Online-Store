using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Data;
using Online_Store.Interfaces;

namespace Online_Store.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signinmanager;
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly ICustomer _customer1;


        public CustomerController(
            ApplicationDbContext context,
            UserManager<IdentityUser> usermanager,
            SignInManager<IdentityUser> signInManager,
            ICustomer customer1
            )
        {
            _context = context;
            _usermanager = usermanager;
            _signinmanager = signInManager;
            _customer1 = customer1; 

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(Customer customer)
        {



            var user = new IdentityUser { UserName = customer.UserName, Email = customer.Email, PhoneNumber = customer.Phone };
            var result = await _usermanager.CreateAsync(user, customer.Password);
            if (result.Succeeded)
            {
                customer.Password = "";
                 
              _context.customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                foreach (var r in result.Errors)
                {
                    ModelState.AddModelError("", r.Description);
                }
                return View(customer);
            }


        }



        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Customer customer)
        {

            var user = await _usermanager.FindByEmailAsync(customer.Email); 
            Microsoft.AspNetCore.Identity.SignInResult result =
                await _signinmanager.PasswordSignInAsync(user, customer.Password, false,false);
            if (result.Succeeded)
            {
                // TempData["UserName"] = user.UserName;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(nameof(user.Email), "Login Failed: Incorrect user or password");
            }
            return View(customer);

        }

        public async Task<IActionResult> Logout()
        {
            await _signinmanager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
