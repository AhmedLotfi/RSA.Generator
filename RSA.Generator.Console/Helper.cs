using System.Security.Cryptography;
using System.Text;

namespace RSAGenerator.Console
{
    internal static class Helper
    {
        public static byte[] Decrypt(byte[] data)
        {
            byte[] privateKey = File.ReadAllBytes("prKey.pem");

            using RSA rsa = RSA.Create();

            rsa.ImportRSAPrivateKey(privateKey, out _);

            return rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
        }

        public static byte[] Ecrypt(byte[] data)
        {
            byte[] pKey = File.ReadAllBytes("pK.pem");

            using RSA rsa = RSA.Create();

            rsa.ImportRSAPublicKey(pKey, out _);

            return rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
        }
    }
}