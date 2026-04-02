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
    [HttpGet] // responde quando o usuário ACESSA a página /Account/Login pelo navegador
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

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}