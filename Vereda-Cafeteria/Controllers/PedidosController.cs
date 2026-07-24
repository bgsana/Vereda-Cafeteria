using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace Vereda_Cafeteria.Controllers;

public class CriarPedidoItemInput
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}

public class CriarPedidoInput
{
    public string NomeCliente { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public FormaPagamento FormaPagamento { get; set; }
    public FormaRecebimento FormaRecebimento { get; set; }
    public decimal TaxaEntrega { get; set; }
    public List<CriarPedidoItemInput> Itens { get; set; } = new();
}

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
        var hoje = DateTime.Today;

        var pedidos = await _context.Pedidos
            .Include(p => p.ItensPedido)
            .ThenInclude(i => i.Produto)
            .Where(p => p.DataPedido.Date == hoje)
            .OrderByDescending(p => p.DataPedido)
            .ToListAsync();
        return View(pedidos);
    }

    // Endpoint público (sem [Authorize]) consumido pelo checkout do site
    // para salvar o pedido no banco antes de abrir o WhatsApp.
    [AllowAnonymous]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar([FromBody] CriarPedidoInput input)
    {
        if (input == null || input.Itens == null || input.Itens.Count == 0)
            return BadRequest("Pedido inválido: nenhum item informado.");

        if (string.IsNullOrWhiteSpace(input.NomeCliente) || string.IsNullOrWhiteSpace(input.Telefone))
            return BadRequest("Nome e telefone são obrigatórios.");

        var produtoIds = input.Itens.Select(i => i.ProdutoId).Distinct().ToList();
        var produtosValidos = await _context.Produtos
            .Where(p => produtoIds.Contains(p.ProdutoId))
            .Select(p => p.ProdutoId)
            .ToListAsync();

        if (produtosValidos.Count != produtoIds.Count)
            return BadRequest("Um ou mais produtos do carrinho não foram encontrados.");

        var pedido = new Pedido
        {
            NomeCliente = input.NomeCliente.Trim(),
            Telefone = input.Telefone.Trim(),
            DataPedido = DateTime.Now,
            FormaPagamento = input.FormaPagamento,
            FormaRecebimento = input.FormaRecebimento,
            Status = StatusPedido.Pendente,
            ValorTotal = input.Itens.Sum(i => i.PrecoUnitario * i.Quantidade) + input.TaxaEntrega
        };

        foreach (var item in input.Itens)
        {
            pedido.ItensPedido.Add(new ItemPedido
            {
                ProdutoId = item.ProdutoId,
                Quantidade = item.Quantidade,
                PrecoUnitario = item.PrecoUnitario,
                SubTotal = item.PrecoUnitario * item.Quantidade
            });
        }

        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync();

        return Ok(new { pedidoId = pedido.PedidoId });
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Confirmar(int id)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido == null) return NotFound();

        pedido.Status = StatusPedido.Confirmado;
        await _context.SaveChangesAsync();
        return Ok();
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Cancelar(int id)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido == null) return NotFound();

        pedido.Status = StatusPedido.Cancelado;
        await _context.SaveChangesAsync();
        return Ok();
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Finalizar(int id)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido == null) return NotFound();

        pedido.Status = StatusPedido.Finalizado;
        await _context.SaveChangesAsync();
        return Ok();
    }
}
