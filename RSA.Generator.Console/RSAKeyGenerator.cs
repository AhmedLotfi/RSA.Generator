using System.Security.Cryptography;

public class RSAKeyGenerator
{
    public static void Init()
    {
        try
        {
            using RSA rsa = RSA.Create(1024);
            byte[] publicKey = rsa.ExportRSAPublicKey();
            byte[] privateKey = rsa.ExportRSAPrivateKey();

            SaveKeyToFile(RSAKeyGeneratorHelpers.PkConst, privateKey);
            SaveKeyToFile(RSAKeyGeneratorHelpers.PConst, publicKey);

            Console.WriteLine("Private Key:{0}",Convert.ToBase64String(privateKey));
            Console.WriteLine("Public Key:{0}",Convert.ToBase64String(publicKey));
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }
    }

    private static void SaveKeyToFile(string fileName, byte[] key)
    {
        try
        {
            using var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            fs.Write(key, 0, key.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to save {0}: {1}", fileName, ex.Message);
        }
    }
}