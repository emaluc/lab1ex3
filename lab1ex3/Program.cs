using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            tastaura */

            Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg.");
            Console.WriteLine("Introduceti numarul");
            ulong numar = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Acesta este ultima cifra a numarului intreg");
            Console.WriteLine(numar % 10);


            
        }
    }
}
