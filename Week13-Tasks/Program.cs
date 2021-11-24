using System;
using System.IO;

namespace Week13_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";

            Console.WriteLine("sisesta kausta nimi:");
            string kaustanimi = Console.ReadLine();
            string newDirectoryFullPath = $@"{rootDirectory}\{kaustanimi}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{kaustanimi} juba eksisteerib.");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"{kaustanimi} tehti kausta Samples.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
