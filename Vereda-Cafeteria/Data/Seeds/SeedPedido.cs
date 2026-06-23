using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;
using Models;
using System;
using System.Collections.Generic;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedPedido
{
    public SeedPedido(ModelBuilder builder)
    {
        builder.Entity<Pedido>().HasData(
            new Pedido
            {
                PedidoId = 1,
                NomeCliente = "João Silva",
                Telefone = "11999999999",
                ValorTotal = 45.50m,
                DataPedido = DateTime.Now.AddDays(-6),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Pronto
            },
            new Pedido
            {
                PedidoId = 2,
                NomeCliente = "Maria Oliveira",
                Telefone = "11988888888",
                ValorTotal = 32.00m,
                DataPedido = DateTime.Now.AddDays(-5),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Preparo
            },
            new Pedido
            {
                PedidoId = 3,
                NomeCliente = "Pedro Santos",
                Telefone = "11977777777",
                ValorTotal = 15.00m,
                DataPedido = DateTime.Now.AddDays(-4),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada // Ajustado pois ConsumoLocal não existe
            },
            new Pedido
            {
                PedidoId = 4,
                NomeCliente = "Ana Costa",
                Telefone = "11966666666",
                ValorTotal = 60.00m,
                DataPedido = DateTime.Now.AddDays(-3),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Preparo
            },
            new Pedido
            {
                PedidoId = 5,
                NomeCliente = "Lucas Mendes",
                Telefone = "11955555555",
                ValorTotal = 25.50m,
                DataPedido = DateTime.Now.AddDays(-2),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Pronto
            },
            new Pedido
            {
                PedidoId = 6,
                NomeCliente = "Julia Lima",
                Telefone = "11944444444",
                ValorTotal = 80.00m,
                DataPedido = DateTime.Now.AddDays(-1),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Preparo
            },
            new Pedido
            {
                PedidoId = 7,
                NomeCliente = "Carlos Ferreira",
                Telefone = "11933333333",
                ValorTotal = 120.50m,
                DataPedido = DateTime.Now,
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada // Ajustado
            },
            new Pedido
            {
                PedidoId = 8,
                NomeCliente = "Fernanda Souza",
                Telefone = "11922222222",
                ValorTotal = 55.00m,
                DataPedido = DateTime.Now,
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega
            }
        );
    }
}
