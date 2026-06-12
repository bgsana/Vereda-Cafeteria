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
    }
}