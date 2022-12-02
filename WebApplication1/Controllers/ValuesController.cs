using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Content("Hi " + id);
        }
    }
}
