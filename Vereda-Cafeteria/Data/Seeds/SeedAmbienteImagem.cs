using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedAmbienteImagem
{
    public SeedAmbienteImagem(ModelBuilder builder)
    {
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
    }
}