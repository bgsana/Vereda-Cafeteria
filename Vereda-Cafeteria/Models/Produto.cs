
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [Display(Name = "Nome do Produto")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
    [Range(0, 9999, ErrorMessage = "A quantidade deve ser no mínimo 1")]
    [Display(Name = "Quantidade em Estoque")]
    public int QtdEstoque { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório")]
    [Range(0.01, 9999.99, ErrorMessage = "O preço deve ser entre no mínimo R$ 0,01")]
    [DataType(DataType.Currency)]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    [Display(Name = "Imagem do Produto")]
    public string ImagemUrl { get; set; }

    [Required]
    [Display(Name = "O produto está ativo?")]
    public bool Ativo { get; set; } = true;

    // Relacionamento: produto pertence a uma categoria
    [ForeignKey("CategoriaId")]
    public virtual Categoria? Categoria { get; set; }

    // Relacionamento: um produto pode estar em muitos itens de pedido
    public virtual ICollection<ItemPedido>? ItensPedido { get; set; }

    // Relacionamento: um produto pode ter várias opções de escolha
    public virtual ICollection<OpcaoProduto>? Opcoes { get; set; }
}