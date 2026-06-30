using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedOpcaoProduto
{
    public SeedOpcaoProduto(ModelBuilder builder)
    {
        List<OpcaoProduto> opcoes = new List<OpcaoProduto>
        {
            // Empada de Barra Bonita (ProdutoId = 3)
            new OpcaoProduto { OpcaoProdutoId = 1,  ProdutoId = 3,  Nome = "Frango c/ milho" },
            new OpcaoProduto { OpcaoProdutoId = 2,  ProdutoId = 3,  Nome = "Frango c/ bacon" },
            new OpcaoProduto { OpcaoProdutoId = 3,  ProdutoId = 3,  Nome = "Brócolis c/ requeijão" },
            new OpcaoProduto { OpcaoProdutoId = 4,  ProdutoId = 3,  Nome = "Alho-poró" },
            new OpcaoProduto { OpcaoProdutoId = 5,  ProdutoId = 3,  Nome = "Palmito c/ parmesão" },

            // Pão de Queijo Recheado (ProdutoId = 10)
            new OpcaoProduto { OpcaoProdutoId = 6,  ProdutoId = 10, Nome = "Requeijão" },
            new OpcaoProduto { OpcaoProdutoId = 7,  ProdutoId = 10, Nome = "Presunto e queijo" },
            new OpcaoProduto { OpcaoProdutoId = 8,  ProdutoId = 10, Nome = "Calabresa" },
            new OpcaoProduto { OpcaoProdutoId = 9,  ProdutoId = 10, Nome = "Doce de leite" },
            new OpcaoProduto { OpcaoProdutoId = 10, ProdutoId = 10, Nome = "Nutella" },
            new OpcaoProduto { OpcaoProdutoId = 11, ProdutoId = 10, Nome = "Goiabada" },

            // Torta Artesanal de Barra Bonita (ProdutoId = 12)
            new OpcaoProduto { OpcaoProdutoId = 12, ProdutoId = 12, Nome = "Frango" },
            new OpcaoProduto { OpcaoProdutoId = 13, ProdutoId = 12, Nome = "Calabresa" },
            new OpcaoProduto { OpcaoProdutoId = 14, ProdutoId = 12, Nome = "Mortadela" },
            new OpcaoProduto { OpcaoProdutoId = 15, ProdutoId = 12, Nome = "Carne" },
            new OpcaoProduto { OpcaoProdutoId = 16, ProdutoId = 12, Nome = "Costela" },
            new OpcaoProduto { OpcaoProdutoId = 17, ProdutoId = 12, Nome = "Pizza" },
        };

        builder.Entity<OpcaoProduto>().HasData(opcoes);
    }
}
