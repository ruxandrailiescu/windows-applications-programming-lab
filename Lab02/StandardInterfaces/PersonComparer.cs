using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInterfaces
{
    internal class PersonComparer : IComparer<Person>
    {
        // Compares two Person objects based on their names in ascending order
        //public int Compare(Person x, Person y)
        //{
        //    if (x == null || y == null)
        //    {
        //        throw new ArgumentNullException("Cannot compare null objects");
        //    }

        //    return x.Name.CompareTo(y.Name);
        //}

        // Compares two Person objects based on their names in descending order
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Cannot compare null objects");
            }

            return y.Name.CompareTo(x.Name);
        }
    }
}
