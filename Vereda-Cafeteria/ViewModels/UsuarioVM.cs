namespace Vereda_Cafeteria.ViewModels;

// representa o usuário autenticado e será usada para trafegar os
// dados do usuário logado pela aplicação sem expor diretamente o AppUse
public class UsuarioVM
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string? FotoPerfil { get; set; }
    public string Roles { get; set; }
    public bool PermissaoAdmin { get; set; } = false; // facilita verificações condicionais nas Views (Ex: exibir ou ocultar menus administrativos)
}

// O Usuario VM expõe apenas as informações necessárias para a interface,
// como nome, e-mail, foto de perfil e o perfil de acesso do usuário