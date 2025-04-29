using System.Security.Cryptography;

public class RSAKeyGenerator
{
    public static void Init()
    {
        try
        {
            using RSA rsa = RSA.Create(3072);
            byte[] publicKey = rsa.ExportRSAPublicKey();
            byte[] privateKey = rsa.ExportRSAPrivateKey();

            SaveKeyToFile("private_key.pem", privateKey);
            SaveKeyToFile("public_key.pem", publicKey);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
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
            Console.WriteLine($"Failed to save {fileName}: {ex.Message}");
        }
    }
}

