using Microsoft.AspNetCore.Identity;
using Vereda_Cafeteria.ViewModels;

namespace Vereda_Cafeteria.Services;

// Define o contrato que uma classe deve cumprir, sem determinar como cada operação será implementada
public interface IUsuarioService
{
    Task<UsuarioVM>GetLoggedUser(); // obtém um usuário logado
    Task<SignInResult>Login (LoginVM login); // Realiza o login
    Task Logout(); // Realiza o logout
}

//A interface declara três operações assíncronas (Task) que qualquer implementação do serviço deverá oferecer