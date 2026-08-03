using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class AuthController : Controller
    {

        public IActionResult Login()
        {
            return Content ("Login Page"); 
        }

        
        public IActionResult Register()
        {
            return Content("Register Page");
        }
    }
}
