using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class wSerieController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetSerie()
        {
            return Ok();
        }
    }
}
