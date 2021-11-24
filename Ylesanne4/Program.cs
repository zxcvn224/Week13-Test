using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\Samples\ylesandekaust";
            Console.WriteLine("Mis sugust faili sisu tahate näha, kas 'stars' või 'planets'");
            string file = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{file}.txt";
            bool exists = File.Exists(fileDirect);
            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (file == "planets" || file == "stars")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{file}.txt ei eksisteeri");
                }
            }
            else
            {
                Console.WriteLine($"{file}.txt ei eksisteeri");
            }
        }
    }
}
