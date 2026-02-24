using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models;

[Table("Evento")]
public class Evento
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(150)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(1000)]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A data é obrigatória")]
    public string DataEvento { get; set; }

    [Required(ErrorMessage = "A imagem é obrigatória")]
    public string ImagemUrlEvento { get; set; }
}