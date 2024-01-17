using Microsoft.AspNetCore.Mvc;

namespace Contouring_App.Presentation.Controllers
{
    public class DevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
