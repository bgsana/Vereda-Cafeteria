using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "O nome da categoria é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [Display(Name = "Nome da Categoria")]
    public string Nome { get; set; }
    
    [Required]
    [StringLength(20)]
    [Display(Name = "Cor da Categoria (Hexadecimal)")]
    public string CorHex { get; set; }

    // Relacionamento: uma categoria tem muitos produtos
    public virtual ICollection<Produto>? Produtos { get; set; }
}