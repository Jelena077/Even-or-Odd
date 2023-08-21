using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());
            CheckNumIsEvenOrOdd(number);
            Console.ReadLine();

        }

        public static void CheckNumIsEvenOrOdd(int _number)
        {
            if (_number % 2 == 0)
            {
                Console.WriteLine("Number {0} is Even", _number);
            }
            else
            {
                Console.WriteLine("Number {0} is Odd", _number);
            }
        }

    }

}