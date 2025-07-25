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


            var x = "MHng/XQQWii00JyDZ1sbvIIMWyhbgtUcmXjUJC+AbbbBIC64JiiKPlScL0tySDtf2ab3VUJTO4g7JQSYY7cNaVK8uX9H+ybeVh5M48mCxyoHPxC3ZaxabjVMhc6moC8EBHH5q1TjJ0hSTaHZGlCYTUimozxXFgV1CjqScxmnEEw=";

            return rsa.Decrypt(Convert.FromBase64String(x), RSAEncryptionPadding.Pkcs1);
            //return rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
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