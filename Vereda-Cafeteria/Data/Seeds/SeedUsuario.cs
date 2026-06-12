using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        List<IdentityRole> roles = new()
        {
            new IdentityRole
            {
                Id = "97feaad6-3218-404f-9c9e-23122c99985a",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);


        List<Usuario> usuarios = new()
        {
            new Usuario
            {
                Id = "12863b4e-bf5a-47f5-b25a-7ac77689a976",
                Email = "bgs.ana08@gmail.com",
                NormalizedEmail = "BGS.ANA08@GMAIL.COM",
                UserName = "bgsana",
                NormalizedUserName = "BGSANA",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Nome = "Ana Lívia",
                FotoPerfil = "/img/usuarios/foto.png"
            },
            new Usuario
            {
                Id = "3eab78a4-3947-44f3-960c-865703a0c1da",
                Email = "dfsntsjunior@gmail.com",
                NormalizedEmail = "DFSNTSJUNIOR@GMAIL.COM",
                UserName = "junin",
                NormalizedUserName = "JUNIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Nome = "Diego Junior",
                FotoPerfil = "/img/usuarios/foto.png"
            }
        };
        foreach (var user in usuarios)
        {
            // cria o gerador de hash de senha (Criptografada)
            PasswordHasher<Usuario> pass = new();
            // gera o hash da senha e salva no usuário
            user.PasswordHash = pass.HashPassword(user, "vereda123");
        }
        builder.Entity<Usuario>().HasData(usuarios);

        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>()
            {
                UserId = "12863b4e-bf5a-47f5-b25a-7ac77689a976",
                RoleId = "97feaad6-3218-404f-9c9e-23122c99985a"
            },
            new IdentityUserRole<string>()
            {
                UserId = "3eab78a4-3947-44f3-960c-865703a0c1da",
                RoleId = "97feaad6-3218-404f-9c9e-23122c99985a"
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}