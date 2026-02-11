namespace Ciphers.Ciphers;

public class CaesarCipher : AbstractCipher
{
    private int rotFactor;
    public CaesarCipher(int rotFactor)
    {
        if (rotFactor >= 0 && rotFactor <= Alphabet.Length)
        {
            this.rotFactor = rotFactor;
        }
        else
        {
            throw new System.ArgumentOutOfRangeException("rotFactor");
        }
    }
    public override string Encrypt(string original)
    {
        string encryptedString = "";
        for (int i = 0; i < original.Length; i++)
        {
            int index = FindCharIndex(original[i]);
            if (index != -1)
            {
                encryptedString += Alphabet[(index + rotFactor) % Alphabet.Length];
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
        string encryptedString = "";
        for (int i = 0; i < cipher.Length; i++)
        {
            int index = FindCharIndex(cipher[i]);
            if (index != -1)
            {
                encryptedString += Alphabet[(index + Alphabet.Length - rotFactor) % Alphabet.Length];
            }
            else
            {
                encryptedString += cipher[i];
            }
        }
        return encryptedString;
    }
}