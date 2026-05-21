using Microsoft.AspNetCore.Mvc;
using Vereda_Cafeteria.Services;
using Vereda_Cafeteria.ViewModels;

namespace Vereda_Cafeteria.Controllers;

[Route("[controller]")]
// gerencia todas as ações relacionadas à conta do usuário
public class ContaController : Controller // dá acesso a View(), RedirectToAction(), TempData, ModelState, etc.
{
    // Dependências injetadas — readonly: só podem ser atribuídas no construtor
    private readonly ILogger<ContaController> _logger; // Registro e logs
    private readonly IUsuarioService _usuarioService; // Lógica de login/logout

    // Construtor — o ASP.NET injeta automaticamente via DI Container
    public ContaController(ILogger<ContaController> logger, IUsuarioService usuarioService)
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

    [HttpGet("Login")] // responde quando o usuário ACESSA a página /Account/Login pelo navegador
    public IActionResult Login(string returnUrl)
    {
        // Cria o ViewModel já com a URL de retorno preenchida
        // returnUrl: ASP.NET passa automaticamente quando o usuário tenta acessar
        // uma página protegida por [Authorize] sem estar logado
        LoginVM loginVM = new()
        {
            // Se returnUrl for null (acesso direto ao login), usa a raiz do site "~/"
            ReturnUrl = returnUrl ?? Url.Content("~/")
        };

        // Envia o ViewModel para a View — ela usa para montar o formulário
        return View(loginVM);
    }

    [HttpPost("Login")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM loginVM)
    {
        if (ModelState.IsValid)
        {
            var result = await _usuarioService.Login(loginVM);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin"); // ← redireciona para o painel
            }
            else if (result.IsLockedOut)
                TempData["Failure"] = "Usuário bloqueado por muitas tentativas.";
            else if (result.IsNotAllowed)
                TempData["Failure"] = "Usuário sem permissão para acessar o sistema.";
            else
                TempData["Failure"] = "E-mail ou senha incorretos. Tente novamente";
        }
        else
            TempData["Failure"] = "Dados inválidos. Verifique os campos preenchidos.";

        return View(loginVM);
    }

    // Logout só aceita POST — nunca GET
    [HttpPost("Logout")]
    [ValidateAntiForgeryToken] // também com proteção CSRF
    public async Task<IActionResult> Logout()
    {
        // // Atribui a responsabilidade de logout ao UserService (que chama SignOutAsync internamente)
        await _usuarioService.Logout();

        // Após deslogar, redireciona para a tela de login
        // RedirectToAction("Action", "Controller") — sem o sufixo "Controller"
        return RedirectToAction("Login", "Conta");
    }
}