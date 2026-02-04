// See https://aka.ms/new-console-template for more information

using CircularArray;

CaesarCipher cipher = new CaesarCipher();

string encoded = cipher.Encode("Aisha", 3);
Console.WriteLine("Encoded text: " + encoded);

string decoded = cipher.Decode(encoded, 3);
Console.WriteLine("Decoded text: " + decoded);

Console.WriteLine("Enter text to encode:");
string text = Console.ReadLine();

Console.WriteLine("Enter shift value:");
int shift = int.Parse(Console.ReadLine());

encoded = cipher.Encode(text, shift);
Console.WriteLine("Encoded text: " + encoded);

decoded = cipher.Decode(encoded, shift);
Console.WriteLine("Decoded text: " + decoded);
