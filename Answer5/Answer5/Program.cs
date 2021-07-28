using System;

namespace Answer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Convertor = new Class1();
            int choice;
            Console.WriteLine("Choose any method to continue : \n 1- Conversion By using default Conversion Rate  \n 2- Conversion By using own Conversion Rate \n 3- Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Convertor.DefaultConversion();
                    break;

                case 2:
                    Convertor.UserConversion();
                    break;
                case 3:
                    break;
            }
        }
    }
}
