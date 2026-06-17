using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("OpcaoProduto")]
public class OpcaoProduto
{
    [Key]
    public int OpcaoProdutoId { get; set; }

    [Required]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Nome da Opção")]
    public string Nome { get; set; }

    // Relacionamento: opção pertence a um produto
    [ForeignKey("ProdutoId")]
    public virtual Produto? Produto { get; set; }
}
