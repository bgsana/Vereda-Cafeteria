using System.ComponentModel.DataAnnotations;

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