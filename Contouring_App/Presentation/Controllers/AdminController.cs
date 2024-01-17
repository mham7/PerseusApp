using Contouring_App.Application.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contouring_App.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Admin>>> GetAllAdmins()
        {
            return null;
        }
    }
}
