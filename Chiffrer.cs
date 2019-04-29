using System;
using System.Security.Cryptography; //Fournit des services de chiffrement, comprenant l'encodage et le décodage sécurisé des données.
using System.Text;//Permet des encodages de caractères ASCII et Unicode.


namespace Application_avec_base_de_donnée
{
    public class Chiffrer
    {
        public static string Chiffre(string text)
        {
            //Methode base64(64 caracteres) pour chiffrer les mots de passes.
            return Convert.ToBase64String(
            ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
            //protectedData = System.Security.Cryptography
            //Encoding = System.Text
        }

        public static string Dechiffre(string text)
        {
            return Encoding.Unicode.GetString(
            ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }
    }
}
