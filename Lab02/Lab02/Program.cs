using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ EXAMPLE 1: Enums ------");

            // Cast from OccupationEnum.Child to System.Int32
            // cast = conversion of one data type to another

            OccupationEnum child = OccupationEnum.Child;
            int childAsInt = (int)OccupationEnum.Child;

            Console.WriteLine("child -> " + child);
            Console.WriteLine("childAsInt -> " + childAsInt);

            // Cast from System.Int32 to OccupationEnum.Student
            int studentToCast = 1;
            OccupationEnum student = (OccupationEnum)studentToCast;

            Console.WriteLine("student -> " + student);

            Console.WriteLine("------ EXAMPLE 2: Value Type Assignment ------");
            ValueTypeAssignment();

            Console.WriteLine("------ EXAMPLE 3: Reference Type Assignment ------");
            ReferenceTypeAssignment();

            Console.ReadLine();
        }

        private static void ValueTypeAssignment()
        {
            var personStruct1 = new PersonStruct(1, "name1", OccupationEnum.Student);
            var personStruct2 = personStruct1;

            Console.WriteLine(personStruct1); // automatically calls .ToString()
                                              // The method is defined in System.Object
                                              // and overridden in PersonStruct
            Console.WriteLine(personStruct2);

            // Change personStruct1.Name and print again
            // personStruct2.Name is not changed
            personStruct1.Name = "NewName";
            Console.WriteLine(personStruct1);
            Console.WriteLine(personStruct2);

            // This behaviour is because value types are copied BY VALUE
            // and modifying one copy does not affect the other copies
        }

        // If you want instances to share the same data, you would use a reference type

        private static void ReferenceTypeAssignment()
        {
            var person1 = new Person(1, "name1", OccupationEnum.Student);
            var person2 = person1;

            Console.WriteLine(person1);
            Console.WriteLine(person2);

            // Change person1.Name and _age and print again
            // person2.Name and _age have changed

            person1.Name = "NewUserName";
            person1.SetAge(22);
            Console.WriteLine("Changed person1.Name and person1._age");
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }

        // person1 and person2 -> both references are pointing to the same object
        // in memory
        // When you assign person2 = person1, you are not creating a new object
        // Instead, both variables refer to the same instance of Person

        // If you want to create a copy of the object instead of having both references
        // pointing to the same instance, you would need to create a new object and
        // copy the values manually or use a copy constructor / cloning mechanism.
    }
}
