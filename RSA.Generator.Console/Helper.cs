using System.Security.Cryptography;
using System.Text;

namespace RSAGenerator.Console
{
    internal static class Helper
    {
        public static string Decrypt(string val)
        {
            byte[] privateKey = File.ReadAllBytes("prKey.pem");

            using RSA rsa = RSA.Create();
            
            rsa.ImportRSAPrivateKey(privateKey, out _);

            byte[] encryptedBytes = Convert.FromBase64String(val);
            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.OaepSHA256);

            return BitConverter.ToString(decryptedBytes);
        }

        public static string Ecrypt(string val)
        {
            byte[] pKey = File.ReadAllBytes("pK.pem");

            using RSA rsa = RSA.Create();

            rsa.ImportRSAPublicKey(pKey, out _);

            byte[] byteArray = Encoding.UTF8.GetBytes(val);

            byte[] enc = rsa.Encrypt(byteArray, RSAEncryptionPadding.OaepSHA256);

            return BitConverter.ToString(byteArray);
        }
    }
}