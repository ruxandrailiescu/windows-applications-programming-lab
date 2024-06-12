using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInterfaces
{
    // A Student object will have all the properties and behaviour of a Person
    internal class Student : Person, ICloneable
    {
        public int[] Marks { get; set; }

        public Student(string name, int age, int[] marks) : base(name, age)
        // call the constructor from the base class
        {
            Marks = marks;
        }

        //public object Clone()
        //{
        //    // First get a shallow copy.

        //    var clone = (Student)MemberwiseClone();

        //    //for reference-type fields (like arrays), it copies the
        //    //references rather than creating new instances.

        //    return clone;
        //}

        // Deep copy
        public object Clone()
        {
            // First get a shallow copy
            var newPerson = (Student)MemberwiseClone();

            // Without the below additional lines, both the original object
            // and the cloned object would reference the same array in memory

            newPerson.Marks = new int[Marks.Length];
            for (var i = 0; i < Marks.Length; i++)
            {
                newPerson.Marks[i] = Marks[i];
            }

            return newPerson;
        }
    }
}
