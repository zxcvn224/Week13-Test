using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\ylesandekaust";
            string starsfile = "stars.txt";
            string planetsfile = "planets.txt";
            string starsfullpath = $@"{rootDirectory}\{starsfile}";
            string fullplanetspath = $@"{rootDirectory}\{planetsfile}";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool starsfullpathexists = File.Exists(starsfile);
            bool planetsfullpathexists = File.Exists(fullplanetspath);

            if (directoryExists && starsfullpathexists && planetsfullpathexists)
            {
                Console.WriteLine($"{starsfile} and {planetsfile} already exists in {rootDirectory}");
            }
            else if (directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(starsfullpath);
                File.Create(fullplanetspath);
                Console.WriteLine($"{starsfile} and {planetsfile} have been created in {rootDirectory}.");

            }
            else
            {
                File.Create(starsfullpath);
                File.Create(fullplanetspath);
                Console.WriteLine($"{starsfile} and {planetsfile} has been created in {rootDirectory}.");
            }
        }
    }
}
