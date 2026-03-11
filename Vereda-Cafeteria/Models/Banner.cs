using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Banner")]
public class Banner
{
    [Key]
    public int BannerId { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres")]
    [Display(Name = "Título (uso interno)")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    [Display(Name = "Imagem do Banner")]
    public string ImagemUrl { get; set; }

    [Required]
    [Display(Name = "O banner está ativo?")]
    public bool Ativo { get; set; }
}