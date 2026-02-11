using System;

namespace Ciphers.Ciphers;

public class CipherDriver
{

    public static void Main(string[] args)
    {
        ICipherInterface cipher;
        string message = "This is a message, which is secret!";
        Console.WriteLine("Original: \r\n" + message +"\n");
        

        cipher = new AtbashCipher();
        string enc = cipher.Encrypt(message);
        Console.WriteLine("Atbash: \r\n"+enc);
        Console.WriteLine(cipher.Decrypt(enc)+"\n");
        
        cipher = new CaesarCipher(13);
        enc = cipher.Encrypt(message);
        Console.WriteLine("Caesar with rotFactor of 13: \r\n" + enc);
        Console.WriteLine(cipher.Decrypt(enc));
    }
}