using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace Vereda_Cafeteria.Controllers;

[Authorize]
public class PedidosController : Controller
{
    private readonly AppDbContext _context;

    public PedidosController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var pedidos = await _context.Pedidos
            .Include(p => p.ItensPedido)
            .ThenInclude(i => i.Produto)
            .OrderByDescending(p => p.DataPedido)
            .ToListAsync();
        return View(pedidos);
    }

    [HttpPost]
    public async Task<IActionResult> AlterarStatus(int id, StatusPedido novoStatus)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido == null)
            return NotFound();

        pedido.Status = novoStatus;
        await _context.SaveChangesAsync();

        return Ok();
    }

    public class AlterarStatusRequest
    {
        public int Id { get; set; }
        public StatusPedido NovoStatus { get; set; }
    }
    [HttpPost]
    public async Task<IActionResult> AlterarStatus([FromBody] AlterarStatusRequest request)
    {
        var pedido = await _context.Pedidos.FindAsync(request.Id);
        if (pedido == null)
            return NotFound();

        pedido.Status = request.NovoStatus;
        await _context.SaveChangesAsync();

        return Ok();
    }
}
