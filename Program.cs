using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz.");
            string surmane = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surmane);
            
            Console.ReadLine();
        }
    }
}