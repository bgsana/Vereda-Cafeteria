using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;
using System.Collections.Generic;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedItemPedido
{
    public SeedItemPedido(ModelBuilder builder)
    {
        builder.Entity<ItemPedido>().HasData(
            // Pedido 1
            new ItemPedido { ItemPedidoId = 1, PedidoId = 1, ProdutoId = 1, Quantidade = 2, PrecoUnitario = 5.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 2, PedidoId = 1, ProdutoId = 18, Quantidade = 1, PrecoUnitario = 16.95m, SubTotal = 16.95m },
            new ItemPedido { ItemPedidoId = 3, PedidoId = 1, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 18.55m, SubTotal = 18.55m },
            
            // Pedido 2
            new ItemPedido { ItemPedidoId = 4, PedidoId = 2, ProdutoId = 10, Quantidade = 2, PrecoUnitario = 5.00m, SubTotal = 10.00m },
            new ItemPedido { ItemPedidoId = 5, PedidoId = 2, ProdutoId = 24, Quantidade = 1, PrecoUnitario = 15.00m, SubTotal = 15.00m },
            new ItemPedido { ItemPedidoId = 6, PedidoId = 2, ProdutoId = 124, Quantidade = 1, PrecoUnitario = 7.00m, SubTotal = 7.00m },

            // Pedido 3
            new ItemPedido { ItemPedidoId = 7, PedidoId = 3, ProdutoId = 24, Quantidade = 1, PrecoUnitario = 15.00m, SubTotal = 15.00m },

            // Pedido 4
            new ItemPedido { ItemPedidoId = 8, PedidoId = 4, ProdutoId = 17, Quantidade = 2, PrecoUnitario = 19.95m, SubTotal = 39.90m },
            new ItemPedido { ItemPedidoId = 9, PedidoId = 4, ProdutoId = 34, Quantidade = 1, PrecoUnitario = 18.55m, SubTotal = 18.55m },

            // Pedido 5
            new ItemPedido { ItemPedidoId = 10, PedidoId = 5, ProdutoId = 1, Quantidade = 3, PrecoUnitario = 5.00m, SubTotal = 15.00m },
            new ItemPedido { ItemPedidoId = 11, PedidoId = 5, ProdutoId = 111, Quantidade = 1, PrecoUnitario = 10.50m, SubTotal = 10.50m },

            // Pedido 6
            new ItemPedido { ItemPedidoId = 12, PedidoId = 6, ProdutoId = 15, Quantidade = 5, PrecoUnitario = 16.00m, SubTotal = 80.00m },

            // Pedido 7
            new ItemPedido { ItemPedidoId = 13, PedidoId = 7, ProdutoId = 7, Quantidade = 4, PrecoUnitario = 15.95m, SubTotal = 63.80m },
            new ItemPedido { ItemPedidoId = 14, PedidoId = 7, ProdutoId = 34, Quantidade = 3, PrecoUnitario = 18.55m, SubTotal = 55.65m },
            new ItemPedido { ItemPedidoId = 15, PedidoId = 7, ProdutoId = 111, Quantidade = 1, PrecoUnitario = 1.05m, SubTotal = 1.05m },

            // Pedido 8
            new ItemPedido { ItemPedidoId = 16, PedidoId = 8, ProdutoId = 22, Quantidade = 2, PrecoUnitario = 16.00m, SubTotal = 32.00m },
            new ItemPedido { ItemPedidoId = 17, PedidoId = 8, ProdutoId = 124, Quantidade = 3, PrecoUnitario = 7.00m, SubTotal = 21.00m },
            new ItemPedido { ItemPedidoId = 18, PedidoId = 8, ProdutoId = 111, Quantidade = 2, PrecoUnitario = 1.00m, SubTotal = 2.00m }
        );
    }
}
