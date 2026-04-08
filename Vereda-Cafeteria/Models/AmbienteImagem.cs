using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vereda_Cafeteria.Models
{
    [Table("AmbienteImagem")]
    public class AmbienteImagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string CaminhoImagem { get; set; }

        public int Ordem { get; set; }

        public bool Ativo { get; set; }
    }
}