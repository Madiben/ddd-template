using Microsoft.AspNetCore.Mvc;
using Application.UseCases;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetPatientDetails(Guid id)
        {
            // Controller logic calling UseCases
            return Ok();
        }
    }
}