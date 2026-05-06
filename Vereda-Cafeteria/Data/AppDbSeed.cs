using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data;

public class AppDbSeed
{
    // O construtor recebe o ModelBuilder
    // Permite inserir dados iniciais nas tabelas
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Categorias
        List<Categoria> categorias = new()
        {
            new Categoria
            {
                CategoriaId = 1,
                Nome = "Pratos Salgados",
                CorHex = "#730000"
            },
            new Categoria
            {
                CategoriaId = 2,
                Nome = "Pratos Doces",
                CorHex = "#00464B"
            },
            new Categoria
            {
                CategoriaId = 3,
                Nome = "Cafés",
                CorHex = "#372314"
            },
            new Categoria
            {
                CategoriaId = 4,
                Nome = "Inspirados",
                CorHex = "#96B9B9"
            },
            new Categoria
            {
                CategoriaId = 5,
                Nome = "Bebidas",
                CorHex = "#CDA05A"
            }
        };

        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Popular Produtos
        List<Produto> produtos = new()
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
        #endregion

        #region Popular Eventos
        List<Evento> eventos = new()
        {
            new Evento
            {
                EventoId = 1,
                Titulo = "Vereda Chaves",
                Descricao = "lorem ipsum",
                ImagemUrl = "/img/usuarios/foto.png",
                DataEvento = new DateTime(2025, 1, 22)
            },
            new Evento
            {
                EventoId = 2,
                Titulo = "Vereda do Amor",
                Descricao = "lorem ipsum",
                ImagemUrl = "/img/usuarios/foto.png",
                DataEvento = new DateTime(2025, 2, 17)
            }
        };

        builder.Entity<Evento>().HasData(eventos);
        #endregion

        #region Popular Banners
        List<Banner> banners = new()
        {
            new Banner
            {
                BannerId = 1,
                Titulo = "Banner sobre ...",
                ImagemUrl = "/img/usuarios/foto.png",
                Ativo = true
            }
        };

        builder.Entity<Banner>().HasData(banners);
        #endregion

        #region Popular Roles - Tipos de Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole
            {
                Id = "97feaad6-3218-404f-9c9e-23122c99985a",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular IdentityUser - Usuários (contas)
        List<Usuario> usuarios = new()
        {
            new Usuario
            {
                Id = "12863b4e-bf5a-47f5-b25a-7ac77689a976",
                Email = "bgs.ana08@gmail.com",
                NormalizedEmail = "BGS.ANA08@GMAIL.COM",
                UserName = "bgsana",
                NormalizedUserName = "BGSANA",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Nome = "Ana Lívia",
                FotoPerfil = "/img/usuarios/foto.png"
            },
            new Usuario
            {
                Id = "3eab78a4-3947-44f3-960c-865703a0c1da",
                Email = "dfsntsjunior@gmail.com",
                NormalizedEmail = "DFSNTSJUNIOR@GMAIL.COM",
                UserName = "junin",
                NormalizedUserName = "JUNIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Nome = "Diego Junior",
                FotoPerfil = "/img/usuarios/foto.png"
            }
        };
        foreach (var user in usuarios)
        {
            // cria o gerador de hash de senha (Criptografada)
            PasswordHasher<Usuario> pass = new();
            // gera o hash da senha e salva no usuário
            user.PasswordHash = pass.HashPassword(user, "vereda123");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>()
            {
                UserId = "12863b4e-bf5a-47f5-b25a-7ac77689a976",
                RoleId = "97feaad6-3218-404f-9c9e-23122c99985a"
            },
            new IdentityUserRole<string>()
            {
                UserId = "3eab78a4-3947-44f3-960c-865703a0c1da",
                RoleId = "97feaad6-3218-404f-9c9e-23122c99985a"
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region Popular Banners
        List<AmbienteImagem> ambienteImagens = new()
        {
            new AmbienteImagem
            {
                Id = 1,
                CaminhoImagem = "/img/NossoAmbiente/amb1.png",
                Ativo = true,
                Ordem = 1
            },
            new AmbienteImagem
            {
                Id = 2,
                CaminhoImagem = "/img/NossoAmbiente/amb2.png",
                Ativo = true,
                Ordem = 2
            },
            new AmbienteImagem
            {
                Id = 3,
                CaminhoImagem = "/img/NossoAmbiente/amb3.png",
                Ativo = true,
                Ordem = 3
            },
            new AmbienteImagem
            {
                Id = 4,
                CaminhoImagem = "/img/NossoAmbiente/amb4.png",
                Ativo = true,
                Ordem = 4
            },
            new AmbienteImagem
            {
                Id = 5,
                CaminhoImagem = "/img/NossoAmbiente/amb5.png",
                Ativo = true,
                Ordem = 5
            },
            new AmbienteImagem
            {
                Id = 6,
                CaminhoImagem = "/img/NossoAmbiente/amb6.png",
                Ativo = true,
                Ordem = 6
            },
            new AmbienteImagem
            {
                Id = 7,
                CaminhoImagem = "/img/NossoAmbiente/amb7.png",
                Ativo = true,
                Ordem = 7
            },
            new AmbienteImagem
            {
                Id = 8,
                CaminhoImagem = "/img/NossoAmbiente/amb8.png",
                Ativo = true,
                Ordem = 8
            },
            new AmbienteImagem
            {
                Id = 9,
                CaminhoImagem = "/img/NossoAmbiente/amb9.png",
                Ativo = true,
                Ordem = 9
            },
            new AmbienteImagem
            {
                Id = 10,
                CaminhoImagem = "/img/NossoAmbiente/amb10.png",
                Ativo = true,
                Ordem = 10
            },
            new AmbienteImagem
            {
                Id = 11,
                CaminhoImagem = "/img/NossoAmbiente/amb11.png",
                Ativo = true,
                Ordem = 11
            },
            new AmbienteImagem
            {
                Id = 12,
                CaminhoImagem = "/img/NossoAmbiente/amb12.png",
                Ativo = true,
                Ordem = 12
            },
        };

        builder.Entity<AmbienteImagem>().HasData(ambienteImagens);
        #endregion
    }
}