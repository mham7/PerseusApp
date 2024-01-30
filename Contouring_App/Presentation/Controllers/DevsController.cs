using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contouring_App.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevsController : ControllerBase
    {

        private readonly IDevService _devService;
        public DevsController(IDevService devService)
        {
            _devService = devService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Dev>>> GetAllDevs()
        {
            if (_devService.GetAll() == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_devService.GetAll());
            }
        }

        [HttpPost("Add")]

        public async Task<ActionResult<Dev>> AddDev(Dev dev)
        {
            if (dev == null)
            {
                return BadRequest();
            }
            else
            {
                _devService.Add(dev);
                return Ok(dev);
            }
        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<Dev>> DeleteDev(int id)
        {
            if (id != 0)
            {
                Dev a = _devService.GetById(id);
                _devService.Delete(a);
                return Ok(a);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPut("Update")]

        public ActionResult<Dev> UpdateDev(Dev dev)
        {
            try
            {
                _devService.Update(dev);
                return Ok(dev);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dev>> GetDev(int id)
        {
            Dev a = _devService.GetById(id);
            if (a == null)
            {
                return NotFound(id);
            }
            else
            {
                return Ok(a);
            }
        }
    }
}

