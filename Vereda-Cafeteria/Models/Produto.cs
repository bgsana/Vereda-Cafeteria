
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [Display(Name = "Nome do produto")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(500)]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório")]
    [Column(TypeName = "decimal(10,2)")]
    [Display(Name = "Preço")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
    [Range(0, 9999, ErrorMessage = "A quantidade deve ser no mínimo 1")]
    [Display(Name = "Quantidade em Estoque")]
    public int QtdEstoque { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    [Display(Name = "Imagem do Produto")]
    public string ImagemUrl { get; set; }

    [Required]
    [Display(Name = "Ativo")]
    public bool Ativo { get; set; } = true;

    // Relacionamento: produto pertence a uma categoria
    [ForeignKey("CategoriaId")]
    public virtual Categoria? Categoria { get; set; }

    // Relacionamento: um produto pode estar em muitos itens de pedido
    public virtual ICollection<ItemPedido>? ItensPedido { get; set; }
}