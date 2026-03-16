using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public enum FormaPagamento
{
    [Display(Name = "Pix")]
    Pix = 1,
    [Display(Name = "Dinheiro")]
    Dinheiro = 2,
    [Display(Name = "Cartão de Crédito")]
    Credito = 3,
    [Display(Name = "Cartão de Débito")]
    Debito = 4,
}