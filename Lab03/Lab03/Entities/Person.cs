using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Entities
{
    // Abstract class = a class that cannot be instantiated on its own
    // May contain abstract methods, which are declared but not implemented in the abstract class

    // Subclasses (derived classes) that inherit from the abstract
    // class must provide concrete implementations for the abstract methods
    internal abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
