namespace Vereda_Cafeteria.Models;

public class EventosViewModel
{
    public Banner? BannerAtivo { get; set; }
    public List<Evento> UltimosEventos { get; set; } = new();
}
