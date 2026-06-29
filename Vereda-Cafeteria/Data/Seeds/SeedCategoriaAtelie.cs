using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedCategoriaAtelie
{
    public SeedCategoriaAtelie(ModelBuilder builder)
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { CategoriaId = 6,  Nome = "Canecas", CorHex = "#730000" },
            new Categoria { CategoriaId = 7,  Nome = "Crochê", CorHex = "#00464B" },
            new Categoria { CategoriaId = 8,  Nome = "Bonecos de Feltro", CorHex = "#372314" },
            new Categoria { CategoriaId = 9,  Nome = "Livros", CorHex = "#96B9B9" },
            new Categoria { CategoriaId = 10,  Nome = "Velas", CorHex = "#CDA05A" },
        };

        builder.Entity<Categoria>().HasData(categorias);
    }
}
