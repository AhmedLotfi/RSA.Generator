using System.Security.Cryptography;

using RSA rsa = RSA.Create(2048);
byte[] publicKey = rsa.ExportRSAPublicKey();
byte[] privateKey = rsa.ExportRSAPrivateKey(); 


Console.WriteLine(publicKey.Length + privateKey.Length);
Console.WriteLine("Public Key:{0}",publicKey);
Console.WriteLine("Private Key:{0}", privateKey);

File.WriteAllBytes("prKey.pem", privateKey);
File.WriteAllBytes("pKey.pem", publicKey);