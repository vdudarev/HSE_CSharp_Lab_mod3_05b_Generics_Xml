using System;
using System.Linq;

namespace Task03_GenericInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Caesar(1);
            Console.Write("Encoded by Caesar english alphabet: ");
            for (var i = 'a'; i <= 'z'; ++i)
                Console.Write(c.Encode(i) + " ");
            Console.WriteLine();
            Console.WriteLine("Decode('z') = " + c.Decode('z'));

            IEncrypted<byte[], string>[] binaryToStringEnc = {
                new WindEncoder(),
                new SideOfTheWorldEncoder()
            };

            var testStrings = new[] { "ЮЗ", "ЮВ", "С", "В" };
            var testBytes = new[]
                { new byte[] { 0, 1, 0 }, new byte[] { 1, 0, 1 }, new byte[] { 1, 1 }, new byte[] { 0, 0 } };

            foreach (var encoder in binaryToStringEnc)
            {
                Console.WriteLine($"Working with type {encoder.GetType().Name} to encode strings {{{string.Join(", ", testStrings)}}}:");
                // TODO: encoder.Encode
                Console.WriteLine($"Decoding:");
                // TODO: encoder.Decode
            }
        }
    }

}