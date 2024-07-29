using Microsoft.AspNetCore.Mvc;

namespace AppBI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

      

        [HttpGet]
        public IActionResult Logout()
        {
            // Perform logout actions here (e.g., clear cookies or session)
            return RedirectToAction("Login");
        }
    }
}
