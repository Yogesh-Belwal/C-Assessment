using System;
using System.IO;

namespace Answer3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter directory path :- ");
            string input = @"" + Console.ReadLine();

            Class1.Search(input);
            Console.ReadKey();
        }
    }
}
