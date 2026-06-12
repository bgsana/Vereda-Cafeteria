using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedProduto
{
    public SeedProduto (ModelBuilder builder)
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                ProdutoId = 1,
                CategoriaId = 2,
                Nome = "Brownie",
                Descricao = "Um brownie irresistível com casquinha crocante por cima e interior extremamente cremoso, denso e úmido.",
                QtdEstoque = 5,
                Preco = 10.50m,
                ImagemUrl = "/img/usuarios/foto.png",
                Ativo = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);
    }
}