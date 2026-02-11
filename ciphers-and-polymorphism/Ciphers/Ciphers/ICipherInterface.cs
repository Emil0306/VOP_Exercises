namespace Ciphers.Ciphers;

public interface ICipherInterface
{
    string Encrypt(string original);
    string Decrypt(string encrypted);
}