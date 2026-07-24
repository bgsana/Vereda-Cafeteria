using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;
using System.Collections.Generic;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedItemPedido
{
    public SeedItemPedido(ModelBuilder builder)
    {
        builder.Entity<ItemPedido>().HasData(
            // Pedido 3
            new ItemPedido { ItemPedidoId = 3, PedidoId = 3, ProdutoId = 10, Quantidade = 3, PrecoUnitario = 7.95m, SubTotal = 23.85m },

            // Pedido 4
            new ItemPedido { ItemPedidoId = 4, PedidoId = 4, ProdutoId = 13, Quantidade = 3, PrecoUnitario = 16.00m, SubTotal = 48.00m },
            new ItemPedido { ItemPedidoId = 5, PedidoId = 4, ProdutoId = 17, Quantidade = 3, PrecoUnitario = 16.00m, SubTotal = 48.00m },

            // Pedido 5
            new ItemPedido { ItemPedidoId = 6, PedidoId = 5, ProdutoId = 17, Quantidade = 5, PrecoUnitario = 16.00m, SubTotal = 80.00m },

            // Pedido 6
            new ItemPedido { ItemPedidoId = 7, PedidoId = 6, ProdutoId = 13, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },

            // Pedido 7
            new ItemPedido { ItemPedidoId = 8, PedidoId = 7, ProdutoId = 10, Quantidade = 7, PrecoUnitario = 7.95m, SubTotal = 55.65m },

            // Pedido 8
            new ItemPedido { ItemPedidoId = 9, PedidoId = 8, ProdutoId = 10, Quantidade = 3, PrecoUnitario = 7.95m, SubTotal = 23.85m },

            // Pedido 9
            new ItemPedido { ItemPedidoId = 10, PedidoId = 9, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 10
            new ItemPedido { ItemPedidoId = 11, PedidoId = 10, ProdutoId = 13, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },
            new ItemPedido { ItemPedidoId = 12, PedidoId = 10, ProdutoId = 17, Quantidade = 3, PrecoUnitario = 16.00m, SubTotal = 48.00m },

            // Pedido 11
            new ItemPedido { ItemPedidoId = 13, PedidoId = 11, ProdutoId = 17, Quantidade = 3, PrecoUnitario = 16.00m, SubTotal = 48.00m },
            new ItemPedido { ItemPedidoId = 14, PedidoId = 11, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 7.95m, SubTotal = 15.90m },

            // Pedido 12
            new ItemPedido { ItemPedidoId = 15, PedidoId = 12, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 7.95m, SubTotal = 15.90m },

            // Pedido 13
            new ItemPedido { ItemPedidoId = 16, PedidoId = 13, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 17, PedidoId = 13, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 14
            new ItemPedido { ItemPedidoId = 18, PedidoId = 14, ProdutoId = 19, Quantidade = 1, PrecoUnitario = 6.00m, SubTotal = 6.00m },
            new ItemPedido { ItemPedidoId = 19, PedidoId = 14, ProdutoId = 17, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },
            new ItemPedido { ItemPedidoId = 20, PedidoId = 14, ProdutoId = 34, Quantidade = 2, PrecoUnitario = 10.00m, SubTotal = 20.00m },

            // Pedido 15
            new ItemPedido { ItemPedidoId = 21, PedidoId = 15, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 7.95m, SubTotal = 15.90m },

            // Pedido 16
            new ItemPedido { ItemPedidoId = 22, PedidoId = 16, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },
            new ItemPedido { ItemPedidoId = 23, PedidoId = 16, ProdutoId = 13, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },

            // Pedido 17
            new ItemPedido { ItemPedidoId = 24, PedidoId = 17, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 25, PedidoId = 17, ProdutoId = 17, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 18
            new ItemPedido { ItemPedidoId = 26, PedidoId = 18, ProdutoId = 22, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 27, PedidoId = 18, ProdutoId = 13, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },

            // Pedido 19
            new ItemPedido { ItemPedidoId = 28, PedidoId = 19, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 29, PedidoId = 19, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 7.95m, SubTotal = 15.90m },

            // Pedido 20
            new ItemPedido { ItemPedidoId = 30, PedidoId = 20, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 21
            new ItemPedido { ItemPedidoId = 31, PedidoId = 21, ProdutoId = 36, Quantidade = 4, PrecoUnitario = 9.95m, SubTotal = 39.80m },
            new ItemPedido { ItemPedidoId = 32, PedidoId = 21, ProdutoId = 17, Quantidade = 4, PrecoUnitario = 16.00m, SubTotal = 64.00m },

            // Pedido 22
            new ItemPedido { ItemPedidoId = 33, PedidoId = 22, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },

            // Pedido 23
            new ItemPedido { ItemPedidoId = 34, PedidoId = 23, ProdutoId = 22, Quantidade = 3, PrecoUnitario = 10.00m, SubTotal = 30.00m },
            new ItemPedido { ItemPedidoId = 35, PedidoId = 23, ProdutoId = 10, Quantidade = 7, PrecoUnitario = 7.95m, SubTotal = 55.65m },

            // Pedido 24
            new ItemPedido { ItemPedidoId = 36, PedidoId = 24, ProdutoId = 19, Quantidade = 1, PrecoUnitario = 6.00m, SubTotal = 6.00m },
            new ItemPedido { ItemPedidoId = 37, PedidoId = 24, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 38, PedidoId = 24, ProdutoId = 24, Quantidade = 1, PrecoUnitario = 17.00m, SubTotal = 17.00m },

            // Pedido 25
            new ItemPedido { ItemPedidoId = 39, PedidoId = 25, ProdutoId = 34, Quantidade = 2, PrecoUnitario = 10.00m, SubTotal = 20.00m },
            new ItemPedido { ItemPedidoId = 40, PedidoId = 25, ProdutoId = 17, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 26
            new ItemPedido { ItemPedidoId = 41, PedidoId = 26, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },
            new ItemPedido { ItemPedidoId = 42, PedidoId = 26, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 43, PedidoId = 26, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },

            // Pedido 27
            new ItemPedido { ItemPedidoId = 44, PedidoId = 27, ProdutoId = 13, Quantidade = 5, PrecoUnitario = 16.00m, SubTotal = 80.00m },

            // Pedido 28
            new ItemPedido { ItemPedidoId = 45, PedidoId = 28, ProdutoId = 24, Quantidade = 4, PrecoUnitario = 17.00m, SubTotal = 68.00m },
            new ItemPedido { ItemPedidoId = 46, PedidoId = 28, ProdutoId = 34, Quantidade = 2, PrecoUnitario = 10.00m, SubTotal = 20.00m },

            // Pedido 29
            new ItemPedido { ItemPedidoId = 47, PedidoId = 29, ProdutoId = 22, Quantidade = 2, PrecoUnitario = 10.00m, SubTotal = 20.00m },
            new ItemPedido { ItemPedidoId = 48, PedidoId = 29, ProdutoId = 13, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },

            // Pedido 30
            new ItemPedido { ItemPedidoId = 49, PedidoId = 30, ProdutoId = 13, Quantidade = 3, PrecoUnitario = 16.00m, SubTotal = 48.00m },

            // Pedido 35
            new ItemPedido { ItemPedidoId = 57, PedidoId = 35, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 58, PedidoId = 35, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },

            // Pedido 36 (Entrega: ValorTotal já inclui +8 de taxa de entrega, não lançada como item)
            new ItemPedido { ItemPedidoId = 59, PedidoId = 36, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 60, PedidoId = 36, ProdutoId = 17, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 37
            new ItemPedido { ItemPedidoId = 61, PedidoId = 37, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 7.95m, SubTotal = 15.90m },
            new ItemPedido { ItemPedidoId = 62, PedidoId = 37, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },

            // Pedido 38
            new ItemPedido { ItemPedidoId = 63, PedidoId = 38, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 64, PedidoId = 38, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },

            // Pedido 39
            new ItemPedido { ItemPedidoId = 65, PedidoId = 39, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },

            // Pedido 40
            new ItemPedido { ItemPedidoId = 66, PedidoId = 40, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 67, PedidoId = 40, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },

            // Pedido 41 (Entrega: ValorTotal já inclui +8 de taxa de entrega, não lançada como item)
            new ItemPedido { ItemPedidoId = 68, PedidoId = 41, ProdutoId = 17, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 69, PedidoId = 41, ProdutoId = 10, Quantidade = 1, PrecoUnitario = 7.95m, SubTotal = 7.95m },

            // Pedido 42
            new ItemPedido { ItemPedidoId = 70, PedidoId = 42, ProdutoId = 17, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m },
            new ItemPedido { ItemPedidoId = 71, PedidoId = 42, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },

            // Pedido 43
            new ItemPedido { ItemPedidoId = 72, PedidoId = 43, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 10.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 73, PedidoId = 43, ProdutoId = 13, Quantidade = 1, PrecoUnitario = 16.00m, SubTotal = 16.00m }
        );
    }
}