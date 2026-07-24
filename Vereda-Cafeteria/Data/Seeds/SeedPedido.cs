using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;
using Models;
using System;

namespace Vereda_Cafeteria.Data.Seeds;

// ATENÇÃO: HasData() exige valores estáticos. Por isso, as datas aqui são fixas
// e representam a semana de 18/07/2026 a 24/07/2026 (últimos 7 dias, com pico
// de vendas na sexta-feira e no sábado).
// Se o projeto for executado em produção futuramente, basta atualizar as datas
// ou migrar para um seeder executado em Program.cs com datas dinâmicas.
public class SeedPedido
{
    public SeedPedido(ModelBuilder builder)
    {
        builder.Entity<Pedido>().HasData(
            new Pedido
            {
                PedidoId = 3,
                NomeCliente = "Patrícia Gomes",
                Telefone = "14938015710",
                ValorTotal = 23.85m,
                DataPedido = new DateTime(2026, 7, 18, 17, 40, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 4,
                NomeCliente = "Rafael Almeida",
                Telefone = "14959889272",
                ValorTotal = 96.00m,
                DataPedido = new DateTime(2026, 7, 18, 17, 50, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 5,
                NomeCliente = "André Monteiro",
                Telefone = "14987117647",
                ValorTotal = 88.00m,
                DataPedido = new DateTime(2026, 7, 18, 10, 15, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 6,
                NomeCliente = "Fábio Guimarães",
                Telefone = "14951716384",
                ValorTotal = 32.00m,
                DataPedido = new DateTime(2026, 7, 18, 19, 20, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 7,
                NomeCliente = "Rogério Xavier",
                Telefone = "14943428808",
                ValorTotal = 55.65m,
                DataPedido = new DateTime(2026, 7, 19, 10, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 8,
                NomeCliente = "Rodrigo Alves",
                Telefone = "14959497534",
                ValorTotal = 23.85m,
                DataPedido = new DateTime(2026, 7, 19, 13, 15, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 35,
                NomeCliente = "Camila Nunes",
                Telefone = "14934187522",
                ValorTotal = 23.95m,
                DataPedido = new DateTime(2026, 7, 19, 11, 20, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 36,
                NomeCliente = "Thiago Barbosa",
                Telefone = "14967452198",
                ValorTotal = 34.00m,
                DataPedido = new DateTime(2026, 7, 19, 15, 45, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 37,
                NomeCliente = "Sabrina Duarte",
                Telefone = "14978291463",
                ValorTotal = 31.90m,
                DataPedido = new DateTime(2026, 7, 19, 18, 0, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 9,
                NomeCliente = "Fernanda Souza",
                Telefone = "14944521238",
                ValorTotal = 24.00m,
                DataPedido = new DateTime(2026, 7, 20, 14, 50, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 10,
                NomeCliente = "Larissa Martins",
                Telefone = "14969125928",
                ValorTotal = 80.00m,
                DataPedido = new DateTime(2026, 7, 20, 16, 0, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 11,
                NomeCliente = "Mônica Andrade",
                Telefone = "14951639035",
                ValorTotal = 71.90m,
                DataPedido = new DateTime(2026, 7, 20, 8, 20, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 12,
                NomeCliente = "Isabela Ramos",
                Telefone = "14925151159",
                ValorTotal = 23.90m,
                DataPedido = new DateTime(2026, 7, 20, 12, 0, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 13,
                NomeCliente = "Ana Costa",
                Telefone = "14959385594",
                ValorTotal = 26.00m,
                DataPedido = new DateTime(2026, 7, 20, 18, 20, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 14,
                NomeCliente = "Renata Dias",
                Telefone = "14964383554",
                ValorTotal = 58.00m,
                DataPedido = new DateTime(2026, 7, 21, 8, 30, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 15,
                NomeCliente = "Vinícius Castro",
                Telefone = "14941864497",
                ValorTotal = 15.90m,
                DataPedido = new DateTime(2026, 7, 21, 18, 10, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 16,
                NomeCliente = "Débora Vieira",
                Telefone = "14969925634",
                ValorTotal = 47.95m,
                DataPedido = new DateTime(2026, 7, 21, 9, 20, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 17,
                NomeCliente = "Diego Ribeiro",
                Telefone = "14936755152",
                ValorTotal = 34.00m,
                DataPedido = new DateTime(2026, 7, 21, 10, 0, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 18,
                NomeCliente = "João Silva",
                Telefone = "14973377544",
                ValorTotal = 42.00m,
                DataPedido = new DateTime(2026, 7, 21, 11, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 19,
                NomeCliente = "Julia Lima",
                Telefone = "14913813174",
                ValorTotal = 25.90m,
                DataPedido = new DateTime(2026, 7, 22, 14, 0, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 20,
                NomeCliente = "Natália Farias",
                Telefone = "14933205749",
                ValorTotal = 16.00m,
                DataPedido = new DateTime(2026, 7, 22, 15, 15, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 21,
                NomeCliente = "Alexandre Tavares",
                Telefone = "14979326800",
                ValorTotal = 111.80m,
                DataPedido = new DateTime(2026, 7, 22, 17, 10, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 22,
                NomeCliente = "Amanda Cardoso",
                Telefone = "14913058277",
                ValorTotal = 7.95m,
                DataPedido = new DateTime(2026, 7, 23, 10, 20, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 23,
                NomeCliente = "Maria Oliveira",
                Telefone = "14911588162",
                ValorTotal = 93.65m,
                DataPedido = new DateTime(2026, 7, 23, 19, 40, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 24,
                NomeCliente = "Felipe Araújo",
                Telefone = "14942811759",
                ValorTotal = 33.00m,
                DataPedido = new DateTime(2026, 7, 23, 15, 10, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 25,
                NomeCliente = "Marcelo Correia",
                Telefone = "14978513996",
                ValorTotal = 36.00m,
                DataPedido = new DateTime(2026, 7, 23, 19, 45, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 26,
                NomeCliente = "Priscila Batista",
                Telefone = "14913120563",
                ValorTotal = 41.95m,
                DataPedido = new DateTime(2026, 7, 23, 16, 15, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 38,
                NomeCliente = "Cristina Azevedo",
                Telefone = "14956317842",
                ValorTotal = 26.00m,
                DataPedido = new DateTime(2026, 7, 23, 11, 10, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 39,
                NomeCliente = "Tatiane Freitas",
                Telefone = "14982749631",
                ValorTotal = 7.95m,
                DataPedido = new DateTime(2026, 7, 23, 17, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 27,
                NomeCliente = "Vanessa Teixeira",
                Telefone = "14964458240",
                ValorTotal = 80.00m,
                DataPedido = new DateTime(2026, 7, 24, 9, 40, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 28,
                NomeCliente = "Pedro Santos",
                Telefone = "14950492067",
                ValorTotal = 88.00m,
                DataPedido = new DateTime(2026, 7, 24, 8, 40, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 29,
                NomeCliente = "Lucas Mendes",
                Telefone = "14995726483",
                ValorTotal = 52.00m,
                DataPedido = new DateTime(2026, 7, 24, 12, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Cancelado
            },
            new Pedido
            {
                PedidoId = 30,
                NomeCliente = "Beatriz Rocha",
                Telefone = "14955340844",
                ValorTotal = 56.00m,
                DataPedido = new DateTime(2026, 7, 24, 17, 15, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 40,
                NomeCliente = "Juliana Rocha",
                Telefone = "14947382915",
                ValorTotal = 26.00m,
                DataPedido = new DateTime(2026, 7, 23, 13, 20, 0),
                FormaPagamento = FormaPagamento.Dinheiro,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 41,
                NomeCliente = "Marcos Vinícius",
                Telefone = "14968217453",
                ValorTotal = 31.95m,
                DataPedido = new DateTime(2026, 7, 23, 18, 10, 0),
                FormaPagamento = FormaPagamento.Credito,
                FormaRecebimento = FormaRecebimento.Entrega,
                Status = StatusPedido.Confirmado
            },
            new Pedido
            {
                PedidoId = 42,
                NomeCliente = "Letícia Souza",
                Telefone = "14975139284",
                ValorTotal = 26.00m,
                DataPedido = new DateTime(2026, 7, 22, 16, 40, 0),
                FormaPagamento = FormaPagamento.Debito,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Finalizado
            },
            new Pedido
            {
                PedidoId = 43,
                NomeCliente = "Henrique Lima",
                Telefone = "14953827461",
                ValorTotal = 26.00m,
                DataPedido = new DateTime(2026, 7, 19, 16, 30, 0),
                FormaPagamento = FormaPagamento.Pix,
                FormaRecebimento = FormaRecebimento.Retirada,
                Status = StatusPedido.Pendente
            }
        );
    }
}