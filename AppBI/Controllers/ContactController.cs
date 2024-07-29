using Microsoft.AspNetCore.Mvc;

namespace AppBI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
