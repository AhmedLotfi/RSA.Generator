using System.Security.Cryptography;

namespace RSAGenerator.Console
{
    internal static class Helper
    {
        public static byte[] Decrypt(byte[] data)
        {
            byte[] privateKey = File.ReadAllBytes(RSAKeyGeneratorHelpers.PkConst);

            using RSA rsa = RSA.Create();

            rsa.ImportRSAPrivateKey(privateKey, out _);

            return rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
        }

        public static byte[] Ecrypt(byte[] data)
        {
            byte[] pKey = File.ReadAllBytes(RSAKeyGeneratorHelpers.PConst);

            using RSA rsa = RSA.Create();

            rsa.ImportRSAPublicKey(pKey, out _);

            return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
        }
    }
}