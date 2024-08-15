using ExpenseTracker.Models;
using ExpenseTracker.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISmsService _smsService;
        private readonly IEmailService _emailService;
        public HomeController(ILogger<HomeController> logger,
            ISmsService smsService,
            IEmailService emailService)
        {
            _logger = logger;
            _smsService = smsService;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            ViewBag.SmsValue = _smsService.GetValues();
            ViewBag.EmailValue = _emailService.GetValues();

            _smsService.ChangeValues();
            _emailService.ChangeValues();

            ViewBag.UpdatedSmsValue = _smsService.GetValues();
            ViewBag.UpdatedEmailValue = _emailService.GetValues();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
