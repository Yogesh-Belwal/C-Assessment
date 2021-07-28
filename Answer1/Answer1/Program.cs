using System;

namespace Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime formDate;
            DateTime toDate;
            Console.WriteLine("Please enter date in format of YYYY/MM/DD");
            void FromDate()
            {
                Console.WriteLine("Please enter from date :- ");
                formDate = Convert.ToDateTime(Console.ReadLine());

                if (formDate > DateTime.Now)
                {
                    Console.WriteLine("Invalid Date ! Enter again");
                    FromDate();
                }
            }

            void ToDate()
            {
                Console.WriteLine("Please enter to date :- ");
                toDate = Convert.ToDateTime(Console.ReadLine());

                if (formDate > toDate)
                {
                    Console.WriteLine("Invalid Date ! Enter again");
                    ToDate();
                }
            }

            FromDate();
            ToDate();
            TimeSpan totalTime = (toDate - formDate);
            int days = totalTime.Days;
            int years = (totalTime.Days / 365);
            int months = (totalTime.Days / 30);
            Console.WriteLine("Total Days :- " + days);
            Console.WriteLine("Total Months :- " + months);
            Console.WriteLine("Total Years :- " + years);
            Console.ReadKey();
        }
    }
}
