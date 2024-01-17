using Microsoft.AspNetCore.Mvc;

namespace Contouring_App.Presentation.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
