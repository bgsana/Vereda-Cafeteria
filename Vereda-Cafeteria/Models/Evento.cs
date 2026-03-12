using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Evento")]
public class Evento
{
    [Key]
    public int EventoId { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O título deve ter no mínimo 3 caracteres")]
    [Display(Name = "Título do Evento")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    [Display(Name = "Imagem do Evento")]
    public string? ImagemUrl { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Data do Evento")]
    public DateTime DataEvento { get; set; }
}