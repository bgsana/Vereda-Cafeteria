using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Vereda_Cafeteria.ViewModels;

// Representa os dados do formulário de login
public class LoginVM
{
    [Required(ErrorMessage = "O email de acesso é obrigatório!")]
    [Display(Name = "E-mail", Prompt = "seu@email.com")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
    public string Email { get; set; }

    [Required(ErrorMessage = "A senha de acesso é obrigatória!")]
    [DataType(DataType.Password)] // oculta os caracteres digitados
    [Display(Name = "Senha", Prompt = "********")]
    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]
    public bool ManterConectado { get; set; } = false;

    [HiddenInput]
    public string UrlRetorno { get; set; } // armazena para qual página o usuário deve ser redirecionado após o login
}