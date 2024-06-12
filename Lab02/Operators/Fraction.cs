using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Fraction
    {
        int num, den;

        // Constructor with parameters
        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        // Overload operator +
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }

        // Overload operator *
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }

        // User-defined conversion from Fraction to double
        public static implicit operator double(Fraction f)
        {
            return (double)f.num / f.den;
        }
    }
}
