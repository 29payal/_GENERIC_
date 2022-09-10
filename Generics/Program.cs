using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        public static void Main(string[] args)
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

            //MAX FLOAT

            MaxFloatNum maxFloatNo = new MaxFloatNum();
            float d = 3.4f, e = 4.4f, f = 6.3f;
            Console.WriteLine("Maximum float value in 1st position :");
            Console.WriteLine(maxFloatNo.PrintMaximumNumber(f, d, e));
            Console.WriteLine("Maximum float value in 2nd position :");
            Console.WriteLine(maxFloatNo.PrintMaximumNumber(d, f, e));
            Console.WriteLine("Maximum float value in 3rd position :");
            Console.WriteLine(maxFloatNo.PrintMaximumNumber( d, e, f));
            Console.WriteLine("_______________________________");

            //MAX STRING

            StringMax stringMax = new StringMax();
            string Fruit1 = "Apple", Fruit2 = "Strawberry", Fruit3 = "Mango";
            Console.WriteLine("Maximum string value in 1st position :");
            Console.WriteLine(stringMax.PrintMaximumString(Fruit2, Fruit1, Fruit3));
            Console.WriteLine("Maximum string value in 2nd position :");
            Console.WriteLine(stringMax.PrintMaximumString(Fruit1, Fruit2, Fruit3));
            Console.WriteLine("Maximum string value in 3rd position :");
            Console.WriteLine(stringMax.PrintMaximumString(Fruit1, Fruit3, Fruit2));
            Console.WriteLine("______________________________");

            //Generic Method for Integer

            Refactor refactor = new Refactor();
            int val = refactor.PrintMaximum<int>(a, b, c);
            Console.WriteLine("Maximum integer number by using generic : " +val);
            Console.WriteLine("_______________________");

            //Generic Method for Float

            float result = refactor.PrintMaximum<float>(d, e, f);
            Console.WriteLine("Maximum float number by using generic :" +result);
            Console.WriteLine("___________________________");

            //Generic Method for String

            string NAME = refactor.PrintMaximum<string>(Fruit1, Fruit2, Fruit3);
            Console.WriteLine("Maximum string name by using generic :" +NAME);

            Console.ReadLine();
        }
    }
}
