using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class WalletsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
