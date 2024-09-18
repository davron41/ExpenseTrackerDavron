using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
