using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria (ModelBuilder builder)
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { CategoriaId = 1, Nome = "Pratos Salgados", CorHex = "#730000"},
            new Categoria { CategoriaId = 2, Nome = "Pratos Doces", CorHex = "#00464B"},
            new Categoria { CategoriaId = 3, Nome = "Cafés", CorHex = "#372314"},
            new Categoria { CategoriaId = 4, Nome = "Inspirados", CorHex = "#96B9B9"},
            new Categoria { CategoriaId = 5, Nome = "Bebidas", CorHex = "#CDA05A"}
        };
        
        builder.Entity<Categoria>().HasData(categorias);
    }
}