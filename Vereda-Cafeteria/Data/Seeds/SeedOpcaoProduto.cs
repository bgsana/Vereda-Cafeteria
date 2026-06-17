using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedOpcaoProduto
{
    public SeedOpcaoProduto(ModelBuilder builder)
    {
        List<OpcaoProduto> opcoes = new List<OpcaoProduto>
        {
            // Pão de Queijo Recheado (ProdutoId = 2)
            new OpcaoProduto { OpcaoProdutoId = 1, ProdutoId = 2, Nome = "Requeijão" },
            new OpcaoProduto { OpcaoProdutoId = 2, ProdutoId = 2, Nome = "Presunto e Queijo" },
            new OpcaoProduto { OpcaoProdutoId = 3, ProdutoId = 2, Nome = "Calabresa" },
            new OpcaoProduto { OpcaoProdutoId = 4, ProdutoId = 2, Nome = "Doce de Leite" },
            new OpcaoProduto { OpcaoProdutoId = 5, ProdutoId = 2, Nome = "Nutella" },
            new OpcaoProduto { OpcaoProdutoId = 6, ProdutoId = 2, Nome = "Goiabada" },
        };

        builder.Entity<OpcaoProduto>().HasData(opcoes);
    }
}
