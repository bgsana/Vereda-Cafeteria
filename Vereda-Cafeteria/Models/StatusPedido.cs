using System.ComponentModel.DataAnnotations;

namespace Models;

public enum StatusPedido
{
    [Display(Name = "Pendente")]
    Pendente = 1,

    [Display(Name = "Confirmado")]
    Confirmado = 2,

    [Display(Name = "Cancelado")]
    Cancelado = 3
}
