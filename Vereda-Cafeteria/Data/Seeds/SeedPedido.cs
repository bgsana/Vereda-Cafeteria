using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;
using Models;
using System;

namespace Vereda_Cafeteria.Data.Seeds;

// ATENÇÃO: HasData() exige valores estáticos. Por isso, as datas aqui são fixas
// e representam a semana de 23/06/2026 a 29/06/2026.
// Se o projeto for executado em produção futuramente, basta atualizar as datas
// ou migrar para um seeder executado em Program.cs com datas dinâmicas.
public class SeedPedido
{
    public SeedPedido(ModelBuilder builder)
    {
        builder.Entity<Pedido>().HasData(
            new Pedido
            {
                PedidoId = 1,
                NomeCliente = "João Silva",
                Telefone = "14991941596",
                ValorTotal = 45.50m,
                DataPedido = new DateTime(2026, 7, 23, 10, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 2,
                NomeCliente = "Maria Oliveira",
                Telefone = "14988888888",
                ValorTotal = 32.00m,
                DataPedido = new DateTime(2026, 7, 23, 11, 0, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 3,
                NomeCliente = "Pedro Santos",
                Telefone = "14977777777",
                ValorTotal = 15.00m,
                DataPedido = new DateTime(2026, 7, 23, 9, 15, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Pendente
            },
            new Pedido
            {
                PedidoId = 4,
                NomeCliente = "Ana Costa",
                Telefone = "14966666666",
                ValorTotal = 60.00m,
                DataPedido = new DateTime(2026, 7, 24, 14, 20, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 5,
                NomeCliente = "Lucas Mendes",
                Telefone = "14955555555",
                ValorTotal = 25.50m,
                DataPedido = new DateTime(2026, 7, 24, 16, 45, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 6,
                NomeCliente = "Julia Lima",
                Telefone = "14944444444",
                ValorTotal = 80.00m,
                DataPedido = new DateTime(2026, 7, 24, 10, 0, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Cancelado
            },
            new Pedido
            {
                PedidoId = 7,
                NomeCliente = "Carlos Ferreira",
                Telefone = "14933333333",
                ValorTotal = 120.50m,
                DataPedido = new DateTime(2026, 7, 24, 8, 30, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 8,
                NomeCliente = "Fernanda Souza",
                Telefone = "14922222222",
                ValorTotal = 55.00m,
                DataPedido = new DateTime(2026, 7, 24, 9, 10, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Confirmado
            }
        );
    }
}
