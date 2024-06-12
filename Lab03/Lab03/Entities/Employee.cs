using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Entities
{
    internal abstract class Employee : Person
    {
        #region Methods

        public void PrintWageNormal()
        {
            Console.WriteLine("Employee - PrintWageNormal");
        }

        // virtual - Indicates that a method can be overridden in derived classes
        // It provides a default implementation but allows subclasses to provide
        // their own implementations
        public virtual void PrintWageVirtual()
        {
            Console.WriteLine("Employee - PrintWageVirtual");
        }

        // abstract - Specifies that a method does not have an implementation in the current class
        // and must be implemented by any concrete (non-abstract) subclass
        // Abstract methods are declared in abstract classes or interfaces
        public abstract void PrintWageAbstract();

        #endregion
        
        public Employee(string name) : base(name) { }
    }
}
