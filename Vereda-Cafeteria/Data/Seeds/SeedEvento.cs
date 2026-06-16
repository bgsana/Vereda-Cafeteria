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
                Titulo = "Vereda Chaves",
                Descricao = "lorem ipsum",
                ImagemUrl = "/img/usuarios/foto.png",
                CorFundo = "#d6dfa0"
            },
            new Evento
            {
                EventoId = 2,
                Titulo = "Vereda do Amor",
                Descricao = "lorem ipsum",
                ImagemUrl = "/img/usuarios/foto.png",
                CorFundo = "#f5c5a3"
            }
        };

        builder.Entity<Evento>().HasData(eventos);
    }
}