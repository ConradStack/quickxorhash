using System;
using System.IO;

namespace QuickXorHashCli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: QuickXorHashCli <path to file>");
                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File '{filePath}' does not exist.");
                return;
            }

            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                QuickXorHash hashAlgorithm = new QuickXorHash();
                byte[] hashValue = hashAlgorithm.ComputeHash(fileBytes);

                Console.WriteLine("Hash value: " + Convert.ToBase64String(hashValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}