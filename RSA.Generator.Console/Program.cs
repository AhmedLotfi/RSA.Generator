using RSAGenerator.Console;
using System.Text;

RSAKeyGenerator.Init();

string textToEncrypt = "Hello, RSA!";
byte[] dataToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

byte[] encryptedData = Helper.Ecrypt(dataToEncrypt);
byte[] decryptedData = Helper.Decrypt(encryptedData);

string decryptedText = Encoding.UTF8.GetString(decryptedData);
Console.WriteLine("Original: {0}", textToEncrypt);
Console.WriteLine("Decrypted: {0}", decryptedText);
