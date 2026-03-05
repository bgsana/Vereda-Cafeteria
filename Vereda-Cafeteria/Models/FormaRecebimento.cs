using System.ComponentModel.DataAnnotations;

namespace Models;

public enum FormaRecebimento
{
    [Display(Name = "Retirada")]
    Retirada = 1,
    [Display(Name = "Entrega")]
    Entrega = 2,
}