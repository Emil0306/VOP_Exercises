using System;

namespace Ciphers.Ciphers;

public class AtbashCipher : AbstractCipher
{
    public override string Encrypt(string original)
    {
        string encryptedString = "";
        for (int i = 0; i < original.Length; i++)
        {
            int index = FindCharIndex(original[i]);
            if (index != -1)
            {
                encryptedString += Alphabet[Alphabet.Length - index - 1];
            }
            else
            {
                encryptedString += original[i];
            }
        }
        return encryptedString;
    }
    public override string Decrypt(string cipher)
    {
        return Encrypt(cipher);
    }
}