using ExpenseTracker.Application.Requests.Auth;
using ExpenseTracker.Application.Requests.Wallet;
using ExpenseTracker.Application.Services.Interfaces;
using ExpenseTracker.Application.Stores.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace ExpenseTracker.Controllers;

[AllowAnonymous]
public class AccountController : Controller
{
    private readonly UserManager<IdentityUser<Guid>> _userManager;
    private readonly SignInManager<IdentityUser<Guid>> _signInManager;
    private readonly IEmailService _emailService;
    private readonly IWalletStore _walletStore;

    public AccountController(
        UserManager<IdentityUser<Guid>> userManager,
        SignInManager<IdentityUser<Guid>> signInManager,
        IEmailService emailService,
        IWalletStore walletStore)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailService = emailService;
        _walletStore = walletStore;
    }

    [HttpGet]
    public IActionResult Login(string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginUserRequest request, string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        if (!ModelState.IsValid)
        {
            return View(request);
        }

        var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password, true, false);

        if (result.Succeeded)
        {
            return RedirectToLocal(returnUrl);
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        return View(request);
    }

    [HttpGet]
    public IActionResult Register(string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterUserRequest model, string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = new IdentityUser<Guid> { Id = Guid.NewGuid(), UserName = model.Email, Email = model.Email };
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            _walletStore.CreateDefault(user.Id);
            await _signInManager.SignInAsync(user, isPersistent: false);
            var to = new List<MailboxAddress>
            {
                new MailboxAddress("", "jamshidchoriyev795@gmail.com"),
                new MailboxAddress("", user.Email)
            };

            _emailService.SendEmail(
                to, 
                "Registration Confirmation", 
                "Thank you for registering to Expense Tracker.");

            return RedirectToLocal(returnUrl);
        }

        AddErrors(result);

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction(nameof(Login));
    }

    private IActionResult RedirectToLocal(string? returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        else
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }

    private void AddErrors(IdentityResult result)
    {
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
    }
}