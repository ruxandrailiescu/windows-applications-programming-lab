using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- EXEMPLE 1: ReferenceTypeArray -----");
            ReferenceTypeArray();

            Console.WriteLine("----- EXEMPLE 2: ShallowCopyEqualOperator -----");
            ShallowCopyEqualOperator();

            Console.WriteLine("----- EXEMPLE 3: DeepCopyICloneable -----");
            DeepCopyICloneable();

            Console.ReadLine();
        }

        private static void ReferenceTypeArray()
        {
            var p1 = new Person("Name3", 42);
            var p2 = new Person("Name1", 23);
            var p3 = new Person("Name2", 32);

            var pArray = new Person[] { p1, p2, p3 };

            // The sorting algorithm uses the CompareTo method of the Person class
            // to determine the order of the elements in the array
            Array.Sort(pArray);

            foreach (var p in pArray)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Sort by name asc/desc using PersonComparer");
            // Uncomment needed method in PersonComparer class

            Array.Sort(pArray, new PersonComparer());

            foreach (var person in pArray)
            {
                Console.WriteLine(person);
            }
        }

        private static void ShallowCopyEqualOperator()
        {
            var p1 = new Student("Name1", 21, new[] { 10, 10, 10 });

            var p2 = p1;    // it creates a new object, but it does not create
                            // new instances of the object
            p1.Age = 12;
            p1.Marks[0] = 2;

            var students = new List<Student>() { p1, p2 };

            foreach (var s in students)
            {
                Console.WriteLine("Student {0}, age {1}, marks {2}",
                    s.Name, s.Age, s.Marks != null ? string.Join(", ", s.Marks) : null);
            }

            // We had same output because the objects reference to the same obj in memory
        }

        private static void DeepCopyICloneable()
        {
            var p1 = new Student("Name1", 21, new[] { 10, 10, 10 });
            
            var p2 = (Student)p1.Clone();

            p1.Age = 12;
            p1.Marks[0] = 1;

            var students = new List<Student>() { p1, p2 };

            foreach (var s in students)
            {
                Console.WriteLine("Student {0}, age {1}, marks {2}",
                    s.Name, s.Age, s.Marks != null ? string.Join(", ", s.Marks) : null);
            }
        }
    }
}