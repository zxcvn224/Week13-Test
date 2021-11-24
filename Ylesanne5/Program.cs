using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("How many facts do you want to see?");
            int number = Convert.ToInt32(Console.ReadLine());

            GetJokes(number);
        }
        private static void GetJokes(int factsnumber)
        {
            string filepath = @"C:\Users\opilane\samples\ylesandekaust\funfacts.txt";
            string[] funfacts = File.ReadAllLines(filepath);

            if (factsnumber > funfacts.Length)
            {
                factsnumber = funfacts.Length;
            }


            for (int i = 0; i < factsnumber; i++)
            {
                Console.WriteLine(funfacts[i]);
            }
        }
    }
}
