# Exercise: Caesar Cipher with a Circular Shift

**Instructions:**

The Caesar cipher is a simple encryption technique that shifts each letter in a message by a fixed number of positions down the alphabet. For example, with a shift of 3, 'A' becomes 'D', 'B' becomes 'E', and so on.

Your task is to implement a Caesar cipher that uses a circular array to handle the alphabet wrapping. For example, with a shift of 3, 'X' should become 'A', 'Y' should become 'B', and 'Z' should become 'C'.

1. **Provided Code**
* A `CaesarCipher` class is provided.
* A private field named `_alphabet` is created that holds an array containing the 26 uppercase English letters.
* A public method `Encode(string text, int shift)` is defined, but not implemented.
* A public method `Decode(string text, int shift)` is defined, but not implemented.
* A class `Program.cs` is provided to demonstrate the encoding and decoding behavior.

2. **Implement** an `Encode(string text, int shift)` method:
    *   Takes a plaintext string and the shift value as input.
    *   Converts the text to uppercase.
    *   For each letter in the text:
        *   Find the letter's position in the circular array.
        *   Shift the position by the given `shift` value, wrapping around the array if necessary.
        *   Append the letter at the new position to the encoded string.
    *   Return the encoded string.

3. **Implement** a `Decode(string text, int shift)` method:
    *   Takes an encoded string and the shift value as input.
    *   Perform the reverse operation of `Encode` to decrypt the message.
4. Execute `Program.cs` to demonstrate the encoding and decoding behavior.

**Example Output:**

        Encoded text: DLVKD
        Decoded text: AISHA
        Enter text to encode:
        Hello
        Enter shift value:
        2
        Encoded text: JGNNQ
        Decoded text: HELLO





