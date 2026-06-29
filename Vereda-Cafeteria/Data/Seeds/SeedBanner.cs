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
                Titulo = "Banner sobre a linha de Bolos de Caneca",
                ImagemUrl = "/img/Banners/banner-bolo-caneca.png",
                Ativo = true
            },
            new Banner
            {
                BannerId = 2,
                Titulo = "Banner sobre o Bolinho de Chuva da Vó Nice",
                ImagemUrl = "/img/Banners/banner-bolinho-chuva.png",
                Ativo = true
            },
            new Banner
            {
                BannerId = 3,
                Titulo = "Banner sobre o Café Coado na Mesa",
                ImagemUrl = "/img/Banners/banner-cafe-coado.png",
                Ativo = true
            }
        };
        builder.Entity<Banner>().HasData(banners);
    }
}