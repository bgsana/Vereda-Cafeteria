using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedProdutoAtelie
{
    public SeedProdutoAtelie(ModelBuilder builder)
    {
        List<Produto> produtos = new List<Produto>
        {
            #region Categoria A

            new Produto
            {
                ProdutoId = 125,
                CategoriaId = 6,
                Nome = "Produto Exemplo A1",
                Descricao = "Descrição do produto exemplo A1. Feito com carinho e dedicação.",
                QtdEstoque = 10,
                Preco = 35.00m,
                ImagemUrl = "/img/atelie/categoria-a/produto-a1.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 126,
                CategoriaId = 6,
                Nome = "Produto Exemplo A2",
                Descricao = "Descrição do produto exemplo A2. Artesanal e exclusivo da Vereda.",
                QtdEstoque = 10,
                Preco = 45.00m,
                ImagemUrl = "/img/atelie/categoria-a/produto-a2.png",
                Ativo = true
            },

            #endregion

            #region Categoria B

            new Produto
            {
                ProdutoId = 127,
                CategoriaId = 7,
                Nome = "Produto Exemplo B1",
                Descricao = "Descrição do produto exemplo B1. Produzido com materiais selecionados.",
                QtdEstoque = 10,
                Preco = 55.00m,
                ImagemUrl = "/img/atelie/categoria-b/produto-b1.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 128,
                CategoriaId = 7,
                Nome = "Produto Exemplo B2",
                Descricao = "Descrição do produto exemplo B2. Um mimo perfeito para presentear.",
                QtdEstoque = 10,
                Preco = 60.00m,
                ImagemUrl = "/img/atelie/categoria-b/produto-b2.png",
                Ativo = true
            },

            #endregion

            #region Categoria C

            new Produto
            {
                ProdutoId = 129,
                CategoriaId = 8,
                Nome = "Produto Exemplo C1",
                Descricao = "Descrição do produto exemplo C1. Exclusivo e feito na Vereda.",
                QtdEstoque = 10,
                Preco = 75.00m,
                ImagemUrl = "/img/atelie/categoria-c/produto-c1.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 130,
                CategoriaId = 8,
                Nome = "Produto Exemplo C2",
                Descricao = "Descrição do produto exemplo C2. Artesanal, com identidade regional.",
                QtdEstoque = 10,
                Preco = 80.00m,
                ImagemUrl = "/img/atelie/categoria-c/produto-c2.png",
                Ativo = true
            },

            #endregion

            #region Categoria D

            new Produto
            {
                ProdutoId = 131,
                CategoriaId = 9,
                Nome = "Produto Exemplo D1",
                Descricao = "Descrição do produto exemplo D1. Ideal para presentear com afeto.",
                QtdEstoque = 10,
                Preco = 90.00m,
                ImagemUrl = "/img/atelie/categoria-d/produto-d1.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 132,
                CategoriaId = 9,
                Nome = "Produto Exemplo D2",
                Descricao = "Descrição do produto exemplo D2. Peça única feita com muito cuidado.",
                QtdEstoque = 10,
                Preco = 100.00m,
                ImagemUrl = "/img/atelie/categoria-d/produto-d2.png",
                Ativo = true
            },

            #endregion
        };

        builder.Entity<Produto>().HasData(produtos);
    }
}
