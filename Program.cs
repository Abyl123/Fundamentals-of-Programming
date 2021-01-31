using System;
using System.Collections.Generic;
using System.Linq;

namespace Hometasks 

   {

    class Lab_1
    {

        static void Main(string[] args)
        {
            //select exercise 
        }
        private static void Ex1()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }



        private static void Ex2()
        {
            Console.Write("Enter a number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number 4: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Average is:", ((num1 + num2 + num3 + num4) / 4));
        }
        private static void Ex3()
        {
            Console.WriteLine("Enter three number X Y Z");
            Console.WriteLine("Enter X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Z");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The result of (x + y) * z is {(x + y) * z}\nThe result of x * y is {x * y} ");
        }

        private static void Ex4()
        {
            Console.Write("Enter the temperature in celsius: ");

            var celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In Kelvins: {0}", celsius + 273.15);
            Console.WriteLine("In Fahrenheit: {0}", celsius * 18 / 10 + 32);
        }

        private static void Ex5()
        {
            Console.Write("Enter the number in HEX: ");

            var hex = Console.ReadLine(); //C1A
            double result = 0.0;


            var count = hex.Length - 1;
            for (int i = 0; i < hex.Length; i++)
            {

                switch (hex[i])
                {
                    case 'A':
                        result += 10 * Math.Pow(16, count);
                        break;

                    case 'B':
                        result += 11 * Math.Pow(16, count);
                        break;

                    case 'C':
                        result += 12 * Math.Pow(16, count);
                        break;

                    case 'D':
                        result += 13 * Math.Pow(16, count);
                        break;

                    case 'E':
                        result += 14 * Math.Pow(16, count);
                        break;

                    case 'F':
                        result += 15 * Math.Pow(16, count);
                        break;

                    default:
                        result += char.GetNumericValue(hex[i]) * Math.Pow(16, count);
                        break;
                }

                count--;

            }

            Console.WriteLine($"Number in decimal is: {result}");
        }







    }
}
 
