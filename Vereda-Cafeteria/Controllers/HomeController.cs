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

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
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
        // Busca todas as categorias com seus produtos ativos
        var categorias = await _context.Categorias
            .Include(c => c.Produtos!.Where(p => p.Ativo))
                .ThenInclude(p => p.Opcoes)
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