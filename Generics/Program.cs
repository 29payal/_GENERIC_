using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics:");

            //MAX INTEGER

            MaxIntegerNo maxIntegerNo = new MaxIntegerNo();
            int a = 10, b = 20, c = 30;
            Console.WriteLine("Maximum integer value in 1st position :");
            Console.WriteLine(maxIntegerNo.PrintMaximumNumber( c, a, b));
            Console.WriteLine("Maximum integer value in 2nd position :");
            Console.WriteLine(maxIntegerNo.PrintMaximumNumber(a, c, b));
            Console.WriteLine("Maximum integer value in 3rd position :");
            Console.WriteLine(maxIntegerNo.PrintMaximumNumber( a, b, c));
            Console.WriteLine("_______________________________________");

            Console.ReadLine();
        }
    }
}
