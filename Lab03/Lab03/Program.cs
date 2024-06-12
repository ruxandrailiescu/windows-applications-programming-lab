using Lab03.Entities;
using Lab03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- EXAMPLE 1 : AbstractNormalVirtualMethods ----");
            AbstractNormalVirtualMethods();

            Console.WriteLine("---- EXAMPLE 2 : CustomInterface ----");
            CustomInterface();
            
            Console.ReadLine();
        }

        private static void AbstractNormalVirtualMethods()
        {
            SoftwareDeveloper sd = new SoftwareDeveloper("SoftwareDeveloper1");
            Employee e = (Employee)sd;

            // Normal method
            sd.PrintWageNormal(); // invokes the method implemented in SoftwareDeveloper
            e.PrintWageNormal();  // invokes the method implemented in the base class Employee

            // Virtual method
            sd.PrintWageVirtual();
            e.PrintWageVirtual();

            // Demonstrates polymorphism = the overridden method in the derived class is called

            // Abstract method
            sd.PrintWageAbstract();
            e.PrintWageAbstract();
        }

        private static void CustomInterface()
        {
            var softwareDeveloper = new SoftwareDeveloper("SoftwareDeveloper1");
            softwareDeveloper.Languages = new[] { "C#", "Java" };

            var manager = new Manager("Manager1");

            var contractor = new Contractor("Contractor1");
            contractor.Languages = new[] { "C#" };

            Person[] persons = new Person[] { softwareDeveloper, manager, contractor };

            // IS Keyword
            foreach (var person in persons)
            {
                if (person is IDeveloper)
                {
                    Console.WriteLine("{0} : {1}", person.Name, string.Join(", ", ((IDeveloper)person).Languages));
                }
            }

            // AS Keyword
            foreach (var person in persons)
            {
                var castToInterface = person as IDeveloper;

                if (castToInterface != null)
                {
                    Console.WriteLine("{0} : {1}", person.Name, string.Join(", ", ((IDeveloper)person).Languages));
                }
            }

            Console.WriteLine("Display only the persons that know C#:");
            foreach (var person in persons)
            {
                if (person is IDeveloper developer && developer.Languages.Contains("C#"))
                {
                    Console.WriteLine("{0} knows C#", person.Name);
                }
            }
        }
    }
}
