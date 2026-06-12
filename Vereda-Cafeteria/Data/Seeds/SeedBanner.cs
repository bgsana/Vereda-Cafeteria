using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedBanner
{
    public SeedBanner(ModelBuilder builder)
    {
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
    }
}