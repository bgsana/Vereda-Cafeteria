using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data.Seeds;

namespace Vereda_Cafeteria.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        new SeedCategoria(builder);
        new SeedProduto(builder);
        new SeedEvento(builder);
        new SeedBanner(builder);
        new SeedUsuario(builder);
        new SeedAmbienteImagem(builder);
        new SeedOpcaoProduto(builder);
        new SeedCategoriaAtelie(builder);
        new SeedProdutoAtelie(builder);
    }
}