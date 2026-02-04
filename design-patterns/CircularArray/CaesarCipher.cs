namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
        string upper = text.ToUpper();
        string result = "";
        for (int i = 0; i < upper.Length; i++)
        {
            result += _alphabet[(upper[i] + shift -65) % _alphabet.Length];
        }
        return result;
    }

    
    
    public string Decode(string text, int shift)
    {
        string upper = text.ToUpper();
        string result = "";
        for (int i = 0; i < upper.Length; i++)
        {
            result += _alphabet[(upper[i] - shift - 65) % _alphabet.Length];
        }
        return result;
    }
}