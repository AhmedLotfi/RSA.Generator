﻿using System.Security.Cryptography;

using RSA rsa = RSA.Create(2048);
byte[] publicKey = rsa.ExportRSAPublicKey();
byte[] privateKey = rsa.ExportRSAPrivateKey(); 

