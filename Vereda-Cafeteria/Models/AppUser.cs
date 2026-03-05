using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Vereda_Cafeteria.Models;

[Table("Usuario")]
public class UserApp : IdentityUser
{
    [Required]
    [StringLength(200)]
    public string Nome { get; set; }

    [StringLength(300)]
    public string? FotoPerfil { get; set; }
}