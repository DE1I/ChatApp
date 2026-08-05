using Microsoft.AspNetCore.Mvc; // Importing the ASP.NET Core MVC namespace, which provides classes and interfaces for building web applications using the Model-View-Controller (MVC) pattern. 

namespace ChatApp.Controllers
{
    public class ChatMessageController : Controller // The ChatMessageController class inherits from the Controller base class, which provides methods and properties for handling HTTP requests and generating responses in an MVC application.
    {
        public IActionResult Index() // This method is an action method in the ChatMessageController class. It handles HTTP requests to the /ChatMessage/Index URL (or simply /ChatMessage if Index is the default action).
        {
            return View(); // "View()" tells ASP.NET Core: "find the .cshtml file that matches
        }


        public IActionResult LandingPage()
        {
            return View();
        }

    }
}
