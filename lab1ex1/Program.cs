using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
• Google: volumul paralelipipedului dreptunghic

             volum = latime * lungime * inaltime;
             */
            Console.WriteLine("Acest program va calcula volumul paralelipipedului dreptunghic");

            Console.WriteLine("Introduceti latimea:");
            int width = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti lungimea:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltime:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Volumum paralelipipedului dreptunghic este: " + width * length * height);
        }
    }
}
