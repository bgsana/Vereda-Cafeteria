using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
     // Construtor que recebe as opções do banco
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
    }

    // DbSet = representa uma tabela no banco de dados
    public DbSet<Categoria> Categorias { get; set;}
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemPedido> ItensPedido { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Banner> Banners { get; set; }
}