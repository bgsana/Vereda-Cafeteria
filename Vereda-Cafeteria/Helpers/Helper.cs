using System.Net.Mail;
using System.Linq; // Adicione este using

namespace Vereda_Cafeteria.Helpers;

public static class Helper
{
    public static bool IsValidEmail(string email)
    {
        try { MailAddress m = new(email); return true; }
        catch { return false; }
    }

    public static string FormatarTelefone(string telefone)
    {
        if (string.IsNullOrEmpty(telefone)) return telefone;
        
        // Remove tudo que não é número
        var numeros = new string(telefone.Where(char.IsDigit).ToArray());

        // Formata: (14) 99194-1596 (11 dígitos)
        if (numeros.Length == 11)
        {
            return string.Format("({0}) {1}-{2}", 
                numeros.Substring(0, 2), 
                numeros.Substring(2, 5), 
                numeros.Substring(7));
        }
        
        return telefone;
    }
}