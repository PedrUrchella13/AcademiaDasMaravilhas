namespace Academia;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AcademiaDasMaravilhas.Mvc.Models;
using AcademiaDasMaravilhas;

public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(string nomeCompleto, string email, string senha)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                NomeCompleto = nomeCompleto
            };

            var resultado = await _userManager.CreateAsync(user, senha);

            if (resultado.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Cliente"); // cadastro público = sempre Cliente
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var erro in resultado.Errors)
                ModelState.AddModelError("", erro.Description);

            return View();
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var resultado = await _signInManager.PasswordSignInAsync(email, senha, isPersistent: false, lockoutOnFailure: false);

            if (resultado.Succeeded)
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "E-mail ou senha inválidos.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }