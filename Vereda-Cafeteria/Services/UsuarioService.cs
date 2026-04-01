using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;
using Vereda_Cafeteria.ViewModels;

namespace Vereda_Cafeteria.Services;

public class UsuarioService : IUsuarioService
{
    // readonly: garante que o campo só pode ser atribuído no construtor
    private readonly SignInManager<Usuario> _signInManager; // Login/Logout
    private readonly UserManager<Usuario> _userManager; // Gerencia de users e roles
    private readonly ILogger<UsuarioService> _logger; // Sistema de Logs
    private readonly AppDbContext _dbContext; // Acesso direto ao banco
    private readonly IHttpContextAccessor _httpContextAccessor; // Acessa a requisição HTTP atual

    // O ASP.NET lê este construtor e injeta automaticamente tudo que estiver
    // registrado no DI Container (injeção de dependências)
    public UsuarioService(
        AppDbContext dbContext,
        IHttpContextAccessor httpContextAccessor,
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        ILogger<UsuarioService> logger
    )
    {
        // cada parâmetro é atribuído ao campo privado correspondente
        _dbContext = dbContext;
        _httpContextAccessor = httpContextAccessor;
        _signInManager = signInManager;
        _userManager = userManager;
        _logger = logger;
    }

    public async Task<UsuarioVM> GetLoggedUser()
    {
        // Lê o ID do usuário a partir das Claims do cookie de autenticação
        // Claims: fichas com informações do usuário, gravadas no cookie após o login
        var usuarioId = _httpContextAccessor.HttpContext.User
            .FindFirstValue(ClaimTypes.NameIdentifier); // campo padrão que armazena o ID

        if (usuarioId == null) return null; // obs: O Controller que chamar este método deve tratar o null

        // Busca o usuário no banco pelo ID
        var usuario = await _dbContext.Usuarios
            .SingleOrDefaultAsync(u => u.Id == usuarioId); // retorna 1 resultado ou null

        // Busca todas as roles do usuário e transforma em uma string
        var roles = string.Join(", ", await _userManager.GetRolesAsync(usuario));
        // Verifica se possui a role de Administrador (retorna bool)
        var permissaoAdmin = await _userManager.IsInRoleAsync(usuario, "Administrador");

        // Monta e retorna o ViewModel com os dados relevantes para a View
        return new UsuarioVM()
        {
            Id = usuarioId,
            Nome = usuario.Nome,
            FotoPerfil = usuario.FotoPerfil,
            Email = usuario.Email,
            UserName = usuario.UserName,
            Roles = roles,
            PermissaoAdmin = permissaoAdmin
        };
    }

    // Método de login — recebe os dados do formulário via LoginVM
    public async Task<SignInResult> Login(LoginVM login)
    {
        // usa o email como UserName p/ a tentativa de login
        string userName = login.Email;
        //Tenta encontrar o usuário pelo email para obter o UserName real
        var usuario = await _userManager.FindByEmailAsync(login.Email);
        // Se o usuário existir, usa o UserName cadastrado
        if (usuario != null) userName = usuario.UserName;

        // Tenta autenticar com senha
        // lockoutOnFailure: true → bloqueia a conta após várias tentativas erradas
        var result = await _signInManager.PasswordSignInAsync(
            userName, login.Senha, login.ManterConectado,
            lockoutOnFailure: true
        );

        // Loga informação de sucesso
        if (result.Succeeded)
            _logger.LogInformation($"Usuário '{userName}' acessou o sistema!");
        // Loga aviso se a conta estiver bloqueada
        if (result.IsLockedOut)
            _logger.LogWarning($"Usuário '{userName}' está bloqueado!");

        // Retorna o result p/ o Controller decidir o que fazer (redireciojnar, mostrar erro)
        return result;
    }

    // Método de Logout - encerra a sessão do usuário
    public async Task Logout()
    {
        //Registra o evento no log
        _logger.LogInformation($"Usuário saiu do sistema");

        // Remove o cookie/sessão de autenticação
        await _signInManager.SignOutAsync();
    }
}