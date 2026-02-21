
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("ProdutoCardapio")]
public class ProdutoCardapio
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

    [StringLength(500)]
    public string Foto { get; set; }

    public bool PossuiSabor { get; set; } = false;
}