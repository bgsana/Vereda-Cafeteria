using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var categoriasAtelie = new[] { 6, 7, 8, 9, 10 };

        var categorias = await _context.Categorias
            .Include(c => c.Produtos!.Where(p => p.Ativo))
            .Where(c => categoriasAtelie.Contains(c.CategoriaId))
            .OrderBy(c => c.CategoriaId)
            .ToListAsync();

        // Intercala os produtos: 1º de cada cat., depois 2º de cada cat., etc.
        var maxProdutos = categorias.Any() ? categorias.Max(c => c.Produtos!.Count) : 0;
        var produtosIntercalados = new List<Produto>();

        for (int i = 0; i < maxProdutos; i++)
        {
            foreach (var cat in categorias)
            {
                var lista = cat.Produtos!.ToList();
                if (i < lista.Count)
                    produtosIntercalados.Add(lista[i]);
            }
        }

        return View(produtosIntercalados);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [Route("PoliticaDePrivacidade")]
    public IActionResult PoliticaDePrivacidade()
    {
        return View();
    }

    [Route("TermosDeUso")]
    public IActionResult TermosDeUso()
    {
        return View();
    }

    [Route("SobreNos")]
    public IActionResult SobreNos()
    {
        return View();
    }

    [Route("Menu")]
    public async Task<IActionResult> Menu()
    {
        var categorias = await _context.Categorias
            .Include(c => c.Produtos!.Where(p => p.Ativo))
                .ThenInclude(p => p.Opcoes)
            .Where(c => new[] { 1, 2, 3, 4, 5 }.Contains(c.CategoriaId))
            .OrderBy(c => c.CategoriaId)
            .ToListAsync();

        return View(categorias);
    }

    [Route("Atelie")]
    public async Task<IActionResult> Atelie()
    {
        var categorias = await _context.Categorias
            .Include(c => c.Produtos!.Where(p => p.Ativo))
                .ThenInclude(p => p.Opcoes)
            .Where(c => new[] { 6, 7, 8, 9, 10 }.Contains(c.CategoriaId))
            .OrderBy(c => c.CategoriaId)
            .ToListAsync();

        return View(categorias);
    }

    [Route("Eventos")]
    public async Task<IActionResult> Eventos()
    {
        var viewModel = new EventosViewModel
        {
            BannerAtivo = await _context.Banners
                .Where(b => b.Ativo)
                .FirstOrDefaultAsync(),

            UltimosEventos = await _context.Eventos
                .OrderByDescending(e => e.EventoId)
                .ToListAsync()
        };

        return View(viewModel);
    }

    [Route("Carrinho")]
    public IActionResult Carrinho()
    {
        return View();
    }

    [Route("FinalizacaoPedido")]
    public IActionResult FinalizacaoPedido()
    {
        return View();
    }

    [Route("NossoAmbiente")]
    public ActionResult NossoAmbiente()
    {
        var imagens = _context.AmbienteImagens
            .Where(i => i.Ativo)
            .OrderBy(i => i.Ordem)
            .ToList();

        return View(imagens);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}