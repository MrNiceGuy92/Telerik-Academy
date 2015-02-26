namespace EncodeOrDecode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of 
//the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

    class EncodeOrDecode
    {
        static void Main()
        {
            char[] cipher = new char[] { '@', '#', '$', '%', '&', '*', }; //Could be any cipher of your choice

            string text = "Telerik Academy."; //Could be any text of your choice

            var encoded = new List<int>();
            var decoded = new List<char>();

            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j >= cipher.Length)
                {
                    j = 0;
                }
                encoded.Add(cipher[j] ^ text[i]);
            }

            Console.WriteLine("Original text:\n{0}\n", text);

            Console.WriteLine("After XOR operation: ");
            foreach (var item in encoded)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("\nEncoded text: ");
            foreach (var item in encoded)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Decoded text: ");
            for (int i = 0, j = 0; i < encoded.Count; i++, j++)
            {
                if (j >= cipher.Length)
                {
                    j = 0;
                }
                decoded.Add((char)(encoded[i] ^ cipher[j]));
            }

            foreach (var item in decoded)
            {
                Console.Write(item);
            }
            Console.WriteLine();

        }
    }

}