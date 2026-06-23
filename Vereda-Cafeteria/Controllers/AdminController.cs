using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Controllers;
[Authorize]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly AppDbContext _context;

        public AdminController(ILogger<AdminController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var hoje = DateTime.Today;
            var ontem = hoje.AddDays(-1);
            var seteDiasAtras = hoje.AddDays(-6);

            // Faturamento Hoje
            var faturamentoHoje = await _context.Pedidos
                .Where(p => p.DataPedido.Date == hoje)
                .SumAsync(p => p.ValorTotal);

            var faturamentoOntem = await _context.Pedidos
                .Where(p => p.DataPedido.Date == ontem)
                .SumAsync(p => p.ValorTotal);

            // Pedidos Hoje
            var pedidosHoje = await _context.Pedidos
                .CountAsync(p => p.DataPedido.Date == hoje);

            var pedidosOntem = await _context.Pedidos
                .CountAsync(p => p.DataPedido.Date == ontem);

            // Ticket Médio
            var ticketMedio = pedidosHoje > 0 ? faturamentoHoje / pedidosHoje : 0;
            var ticketMedioOntem = pedidosOntem > 0 ? faturamentoOntem / pedidosOntem : 0;

            // Item mais pedido hoje
            var itemMaisPedidoData = await _context.ItensPedido
                .Include(i => i.Produto)
                .Where(i => i.Pedido.DataPedido.Date == hoje)
                .GroupBy(i => i.Produto.Nome)
                .Select(g => new { Nome = g.Key, Total = g.Sum(i => i.Quantidade) })
                .OrderByDescending(g => g.Total)
                .FirstOrDefaultAsync();

            // Faturamento da Semana (últimos 7 dias)
            var faturamentoSemana = await _context.Pedidos
                .Where(p => p.DataPedido.Date >= seteDiasAtras)
                .GroupBy(p => p.DataPedido.Date)
                .Select(g => new { Dia = g.Key, Total = g.Sum(p => p.ValorTotal) })
                .ToListAsync();

            var diasSemana = new[] { "dom", "seg", "ter", "qua", "qui", "sex", "sáb" };
            var faturamentoDiarioList = new List<FaturamentoDiario>();
            for (int i = 0; i < 7; i++)
            {
                var data = seteDiasAtras.AddDays(i);
                var valor = faturamentoSemana.FirstOrDefault(f => f.Dia == data.Date)?.Total ?? 0;
                faturamentoDiarioList.Add(new FaturamentoDiario 
                { 
                    Dia = diasSemana[(int)data.DayOfWeek], 
                    Valor = valor 
                });
            }

            // Top Produtos (Geral ou Hoje)
            var topProdutosData = await _context.ItensPedido
                .Include(i => i.Produto)
                .ThenInclude(p => p.Categoria)
                .GroupBy(i => new { i.Produto.Nome, Categoria = i.Produto.Categoria.Nome })
                .Select(g => new TopProduto
                {
                    Nome = g.Key.Nome,
                    Categoria = g.Key.Categoria,
                    Quantidade = g.Sum(i => i.Quantidade)
                })
                .OrderByDescending(p => p.Quantidade)
                .Take(4)
                .ToListAsync();

            var maxQtd = topProdutosData.Any() ? topProdutosData.Max(p => p.Quantidade) : 1;
            foreach(var p in topProdutosData) {
                p.Percentual = (p.Quantidade * 100) / maxQtd;
            }

            // Pedidos Recentes
            var pedidosRecentes = await _context.Pedidos
                .OrderByDescending(p => p.DataPedido)
                .Take(5)
                .ToListAsync();

            var viewModel = new DashboardVM
            {
                FaturamentoHoje = faturamentoHoje,
                PedidosHoje = pedidosHoje,
                TicketMedio = ticketMedio,
                ItemMaisPedido = itemMaisPedidoData?.Nome ?? "Nenhum",
                QtdItemMaisPedido = itemMaisPedidoData?.Total ?? 0,
                
                PercentualFaturamentoVariacao = faturamentoOntem > 0 ? ((faturamentoHoje - faturamentoOntem) / faturamentoOntem) * 100 : 0,
                VariacaoPedidos = pedidosHoje - pedidosOntem,
                VariacaoTicketMedio = ticketMedio - ticketMedioOntem,

                FaturamentoSemana = faturamentoDiarioList,
                TopProdutos = topProdutosData,
                PedidosRecentes = pedidosRecentes
            };

            return View(viewModel);
        }
    }