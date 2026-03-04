using System.ComponentModel.DataAnnotations;

namespace Vereda_Cafeteria.Models;

public class Pedido
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(125)]
    public string NomeCliente { get; set; }
    
    [Required(ErrorMessage = "O telefone é obrigatório")]
    [StringLength(50)]
    public string Telefone { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DataPedido { get; set; } = DateTime.Now;
}