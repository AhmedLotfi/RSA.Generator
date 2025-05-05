using RSAGenerator.Console;
using System.Text;

string _continue = "no";

do
{

    RSAKeyGenerator.Init();

    Console.WriteLine("Enter value:");
    string val = Console.ReadLine()!;

    string textToEncrypt = val;
    byte[] dataToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

    byte[] encryptedData = Helper.Ecrypt(dataToEncrypt);
    byte[] decryptedData = Helper.Decrypt(encryptedData);

    string decryptedText = Encoding.UTF8.GetString(decryptedData);

    Console.WriteLine("-----------");
    Console.WriteLine("Encrypted 64: {0}", Convert.ToBase64String(encryptedData));
    Console.WriteLine("-----------");
    Console.WriteLine("Original: {0}", textToEncrypt);
    Console.WriteLine("-----------");
    Console.WriteLine("Decrypted: {0}", decryptedText);
    Console.WriteLine("-----------");
    Console.WriteLine("Rotate keys ? yes/no");
    string rotate = Console.ReadLine()!;

    if(rotate == "yes" || rotate == "Yes")
    {
        RSAKeyGenerator.Init();

        Console.WriteLine("-----------");

        Console.WriteLine("Keys are rotated");
    }

    Console.WriteLine("-----------");

    Console.WriteLine("Continue ? yes/no");
    _continue = Console.ReadLine()!;

} while (_continue == "yes" || _continue == "Yes");
