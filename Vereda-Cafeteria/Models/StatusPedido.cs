using System.ComponentModel.DataAnnotations;

namespace Models;

public enum StatusPedido
{
    [Display(Name = "Pendente")]
    Pendente = 1,
    
    [Display(Name = "Em Preparo")]
    Preparo = 2,
    
    [Display(Name = "Pronto")]
    Pronto = 3,
    
    [Display(Name = "Entregue")]
    Entregue = 4,
    
    [Display(Name = "Cancelado")]
    Cancelado = 5
}
