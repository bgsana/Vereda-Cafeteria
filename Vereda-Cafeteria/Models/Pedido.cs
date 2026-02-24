using System.ComponentModel.DataAnnotations;

namespace Vereda_Cafeteria.Models;

public class Pedido
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(125)]
    public string NomeCliente { get; set; }
}