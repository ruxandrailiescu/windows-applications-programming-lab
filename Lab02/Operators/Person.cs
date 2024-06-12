using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }

        #endregion

        public Person() 
        {
            Console.WriteLine("Person->Person()");
        }

        public Person(string name, int age)
        {
            Console.WriteLine("Person->Person(string name, int age)");
            Name = name;
            Age = age;
        }

        #region Override
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }

        #endregion

        #region Operators

        // Explicitly convert an instance of the Person class to an int
        public static explicit operator int(Person p)
        {
            return p.Age;
        }

        // True if the Age of p1 is less than the Age of p2
        // Otherwise, returns false
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        // True if the Age of p1 is greater than the Age of p2
        // Otherwise, returns false
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        #endregion
    }
}
