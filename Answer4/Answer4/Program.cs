using System;
using System.Collections.Generic;

namespace Answer4
{
    class Program
    {
        void Insert()
        {
            Console.Write("Enter the length :- ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Data : ");
            List<int> userList = new List<int>();
            for (int i = 0; i <= temp; i++)
            {
                if (i == temp)
                {
                    Console.WriteLine("Memory is full!");
                    Insert();
                }
                else
                {
                    var input = Console.ReadLine();

                    if (input == "?")
                    {
                        userList.Sort();
                        Console.WriteLine("Sorted Data as follows:- ");
                        foreach (int j in userList)
                        {
                            Console.WriteLine(j);
                        }
                        Insert();
                    }
                    else
                    {
                        userList.Add(Convert.ToInt32(input));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Insert();
           
        }
    }
}
