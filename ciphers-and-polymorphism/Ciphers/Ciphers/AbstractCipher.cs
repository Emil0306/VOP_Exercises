using System;
using System.Linq;

namespace Ciphers.Ciphers;

public abstract class AbstractCipher : ICipherInterface
{
    public static readonly char[] Alphabet =
    [
        'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F'
        , 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M'
        , 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T'
        , 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z'
    ];

    public abstract string Encrypt(string original);
    public abstract string Decrypt(string encrypted);

    protected int FindCharIndex(char ch)
    {
        throw new NotImplementedException("Not implemented!");
    }
}