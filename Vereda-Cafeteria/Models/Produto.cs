
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Produto")]
public class ProdutoMenu
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(200)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(500)]
    public string Descricao { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
    public int QtdEstoque { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    [StringLength(500)]
    public string ImagemUrl { get; set; }

    public bool PossuiSabor { get; set; } = false;
}