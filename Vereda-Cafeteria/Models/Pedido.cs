using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models;

namespace Vereda_Cafeteria.Models;

[Table("Pedido")]
public class Pedido
{
    [Key]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [Display(Name = "Nome do Cliente")]
    public string NomeCliente { get; set; }
    
    [Required(ErrorMessage = "O telefone é obrigatório")]
    [StringLength(20, MinimumLength = 10, ErrorMessage = "Telefone inválido")]
    [Phone(ErrorMessage = "Telefone inválido")]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }
    
    [Required(ErrorMessage = "O valor total é obrigatório")]
    [Range(0.01, 99999.99, ErrorMessage = "Valor inválido")]
    [DataType(DataType.Currency)]
    [Display(Name = "Valor Total")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal ValorTotal { get; set; }
    
    [Required]
    [DataType(DataType.DateTime)]
    [Display(Name = "Data do Pedido")]
    public DateTime DataPedido { get; set; } = DateTime.Now;

    [Required]
    [Display(Name = "Forma de Pagamento")]
    public FormaPagamento FormaPagamento { get; set; }

    [Required]
    [Display(Name = "Forma de Recebimento")]
    public FormaRecebimento FormaRecebimento { get; set; }

    [Required]
    [Display(Name = "Status do Pedido")]
    public StatusPedido Status { get; set; } = StatusPedido.Pendente;

    // Relacionamento: um pedido tem muitos itens
    public virtual Collection<ItemPedido> ItensPedido { get; set; } = new();
}