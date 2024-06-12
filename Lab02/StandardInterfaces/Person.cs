using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInterfaces
{
    internal class Person : IComparable<Person>
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        // Right-click, choose "Quick Actions and Refactorings," then "Generate Constructor"
        // Select the properties you want to include in the constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }

        // 1. Compare by name
        //public int CompareTo(Person other)
        //{
        //    return Name.CompareTo(other.Name);
        //}

        // 2. Compare by age in descending order
        //public int CompareTo(Person other)
        //{
        //    return other.Age.CompareTo(Age);
        //}

        // 3. Sort the persons using 2 criteria at the same time (name and age)
        public int CompareTo(Person other)
        {
            // first we compare by name
            int nameComparison = Name.CompareTo(other.Name);

            // then, if names are the same, compare by age
            if (nameComparison == 0)
            {
                return Age.CompareTo(other.Age);
            }

            return nameComparison;
        }
    }
}
