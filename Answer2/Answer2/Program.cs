using System;
using System.Globalization;

namespace Answer2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter your string :- ");
            String input = Console.ReadLine();
            string output = input.ToTitleCase();
            Console.WriteLine("Formatted string :- "+ output);
            Console.ReadKey();
        }
    }
}
