using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("ItemPedido")]
public class ItemPedido
{
    [Key]
    public int ItemPedidoId { get; set; }

    [Required]
    public int PedidoId { get; set; }

    [Required]
    public int ProdutoId { get; set; }

    [Required]
    [Range(1, 99, ErrorMessage = "Quantidade deve ser entre 1 e 99")]
    [Display(Name = "Quantidade")]
    public int Quantidade { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Display(Name = "Preço Unitário")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal PrecoUnitario { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(10,2)")]
    public decimal SubTotal { get; set; }

    // Relacionamentos:
    [ForeignKey("PedidoId")]
    public virtual Pedido? Pedido { get; set; }

    [ForeignKey("ProdutoId")]
    public virtual Produto? Produto { get; set; }
}