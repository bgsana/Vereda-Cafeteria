using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedEvento
{
    public SeedEvento(ModelBuilder builder)
    {
        List<Evento> eventos = new List<Evento>
        {
            new Evento
            {
                EventoId = 1,
                Titulo = "Vereda do Amor",
                Descricao = "Em comemoração ao Dia dos Namorados, a Vereda se transformou em um espaço ainda mais especial. Decoração temática, música ao vivo e pratos exclusivos para a ocasião criaram um ambiente romântico e acolhedor para os casais. Um evento pensado para transformar uma data especial em uma lembrança que fica.",
                ImagemUrl = "/img/Eventos/vereda-do-amor.png",
                CorFundo = "#f1a1a1"
            },
            new Evento
            {
                EventoId = 2,
                Titulo = "Vereda do Chaves",
                Descricao = "Por quinze dias, a Vereda mergulhou no universo do seriado mais querido do Brasil. Ao lado do cardápio tradicional, os clientes encontraram receitas recriadas com carinho, churros, suco de tamarindo, sanduíches e tortas inspirados nas cenas mais icônicas do Chaves. Um evento cheio de nostalgia, sabor e aquele sorriso de quem revive uma memória afetiva.",
                ImagemUrl = "/img/Eventos/vereda-do-chaves.png",
                CorFundo = "#d6dfa0"
            }
        };

        builder.Entity<Evento>().HasData(eventos);
    }
}