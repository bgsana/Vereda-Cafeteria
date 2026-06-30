using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;
using Vereda_Cafeteria.Services;

var builder = WebApplication.CreateBuilder(args);

// --- ADICIONA SERVIÇOS AO CONTAINER DA APLICAÇÃO ---
// Ativa o padrão MVC (Controllers + Views)
builder.Services.AddControllersWithViews();

// --- CONFIGURAÇÃO DO BANCO DE DADOS (MYSQL) ---

// Lê a Connection String
string conexao = builder.Configuration.GetConnectionString("VeredaDb");
// Registra o AppDbContext como serviço => permite injeção de dependência nos controllers
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(conexao)
);

// --- CONFIGURAÇÃO DO IDENTITY (AUTENTICAÇÂO) ---

// Configura o sistema de login usando a entidade Usuario
builder.Services.AddIdentity<Usuario, IdentityRole>(options =>
{
    //Não exige confirmação de email para o login
    options.SignIn.RequireConfirmedEmail = false;

    // Garante que cada usuário tenha email único
    options.User.RequireUniqueEmail = true;
})
// Diz ao Identity para usar o EntityFramework
.AddEntityFrameworkStores<AppDbContext>()

// Habilita geração de tokens (reset senha etc)
.AddDefaultTokenProviders();

// Registro do serviço de usuário
// AddTransient(1 dos 3 tipos): uma nova instância do UserService será criada a cada vez que ele for solicitado
builder.Services.AddTransient<IUsuarioService, UsuarioService>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Conta/Login";
    options.AccessDeniedPath = "/Conta/Login";
    options.ExpireTimeSpan = TimeSpan.FromHours(8);
    options.SlidingExpiration = true;
    options.Cookie.HttpOnly = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});
// --- CRIA A APLICAÇÂO ---

var app = builder.Build();

// --- GARANTE QUE O BANCO DE DADOS EXISTA ---

// Cria um escopo de serviço temporário
using (var scope = app.Services.CreateScope())
{
    // Obtém o contexto do banco
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // Se o banco não existir ele será criado automaticamente
    await db.Database.EnsureCreatedAsync();
}

// --- CONFIGURAÇÃO DO PIPELINE HTTP ---
if (!app.Environment.IsDevelopment())
{
    // Página de erro padrão
    app.UseExceptionHandler("/Home/Error");
    // Habilita HSTS (segurança HTTPS)
    app.UseHsts();
}

// Redireciona HTTP → HTTPS
app.UseHttpsRedirection();

// Permite servir arquivos estáticos (css, js, imagens)
app.UseStaticFiles();

// Habilita roteamento
app.UseRouting();

// Habilita autenticação
app.UseAuthentication();

// Habilita autorização
app.UseAuthorization();

// --- CONFIGURAÇÃO DAS ROTAS ---

// Rota padrão do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


// --- INICIA A APLICAÇÃO ---
app.Run();