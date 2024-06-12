using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Name1", 21);
            var p2 = new Person("Name2", 22);

            // Explicit cast to int
            int ageExplicit = (int)p;
            Console.WriteLine("Age (explicit): {0}", ageExplicit);

            if (p < p2)
                Console.WriteLine("p.Age < p2.Age");

            Console.WriteLine("----- Fraction example -----");

            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 7);
            Fraction c = new Fraction(2, 3);
            Console.WriteLine((double)(a * b + c));

            Console.ReadLine();
        }
    }
}
