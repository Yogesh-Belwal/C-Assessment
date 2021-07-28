using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Answer5
{
    class Class1
    {
        public void UserConversion()
        {
            

            int choice;

            Console.WriteLine("Enter your Choice :\n 1 - Dollar to Rupee \n 2 - Bitcoin to Rupee \n 3 - Ripple  to Rupee  \n 4 - Polygon to Rupee \n 5 - Pound to Rupee \n 6 - Exit");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Double dollar, rupe, dollarValue;
                    Console.WriteLine("Enter the Dollar Amount :");
                    dollar = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Dollar Value :");
                    dollarValue = double.Parse(Console.ReadLine());
                    rupe = dollar * dollarValue;
                    Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupe);
                    UserConversion();
                    break;
                case 2:
                    Double bitcoin, rupe2, bitcoinValue;
                    Console.WriteLine("Enter the Bitcoin Amount :");
                    bitcoin = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Bitcoin Value :");
                    bitcoinValue = double.Parse(Console.ReadLine());
                    rupe2 = bitcoin * bitcoinValue;
                    Console.WriteLine("{0} Bitcoin Equals {1} Rupees", bitcoin, rupe2);
                    UserConversion();
                    break;
                case 3:
                    Double ripple, rupe3, rippleValue;
                    Console.WriteLine("Enter the Ripple Amount :");
                    ripple = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Ripple Value :");
                    rippleValue = double.Parse(Console.ReadLine());
                    rupe3 = ripple * rippleValue;
                    Console.WriteLine("{0} Ripple Equals {1} Rupees",ripple, rupe3);
                    UserConversion();
                    break;
                case 4:
                    Double polygon, rupe4, polygonValue;
                    Console.WriteLine("Enter the Polygon Amount :");
                    polygon = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Polygon Value :");
                    polygonValue = double.Parse(Console.ReadLine());
                    rupe4 = polygon * polygonValue;
                    Console.WriteLine("{0} Polygon Equals {1} Rupees",polygon, rupe4);
                    UserConversion();
                    break;
                case 5:
                    Double pound, rupe5, poundValue;
                    Console.WriteLine("Enter the Pound Amount :");
                    pound = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Pound Value :");
                    poundValue = double.Parse(Console.ReadLine());
                    rupe5 = pound * poundValue;
                    Console.WriteLine("{0} Pound Equals {1} Rupees",pound, rupe5);
                    UserConversion();
                    break;

                case 6:
                    break;

            }
            
        }


        public void DefaultConversion()
        {
            int choice;

            Console.WriteLine("Enter your Choice :\n 1 - Dollar to Rupee \n 2 - Bitcoin to Rupee \n 3 - Ripple  to Rupee  \n 4 - Polygon to Rupee \n 5 - Pound to Rupee \n 6 - Exit");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Double dollar, rupe, dollarValue=80;
                    Console.WriteLine("Enter the Dollar Amount :");
                    dollar = Double.Parse(Console.ReadLine());
                    rupe = dollar * dollarValue;
                    Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupe);
                    DefaultConversion();
                    break;
                case 2:
                    Double bitcoin, rupe2, bitcoinValue=230000;
                    Console.WriteLine("Enter the Bitcoin Amount :");
                    bitcoin = Double.Parse(Console.ReadLine());
                    rupe2 = bitcoin * bitcoinValue;
                    Console.WriteLine("{0} Bitcoin Equals {1} Rupees", bitcoin, rupe2);
                    DefaultConversion();
                    break;
                case 3:
                    Double ripple, rupe3, rippleValue=70;
                    Console.WriteLine("Enter the Ripple Amount :");
                    ripple = Double.Parse(Console.ReadLine());
                    rupe3 = ripple * rippleValue;
                    Console.WriteLine("{0} Ripple Equals {1} Rupees",ripple, rupe3);
                    DefaultConversion();
                    break;
                case 4:
                    Double polygon, rupe4, polygonValue=500;
                    Console.WriteLine("Enter the Polygon Amount :");
                    polygon = Double.Parse(Console.ReadLine());
                    rupe4 = polygon * polygonValue;
                    Console.WriteLine("{0} Polygon Equals {1} Rupees",polygon, rupe4);
                    DefaultConversion();
                    break;
                case 5:
                    Double pound, rupe5, poundValue=97;
                    Console.WriteLine("Enter the Pound Amount :");
                    pound = Double.Parse(Console.ReadLine());
                    rupe5 = pound * poundValue;
                    Console.WriteLine("{0} Pound Equals {1} Rupees",pound, rupe5);
                    DefaultConversion();
                    break;
                case 6:
                    break;

            }
            
        }
    }
}
