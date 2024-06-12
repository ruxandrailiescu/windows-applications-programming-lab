using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Person
    {
        #region Properties

        #region Age - without using properties

        private int _age;
        public int GetAge()
        {
            return _age;    // this._age is implicit
        }
        public void SetAge(int value)
        {
            _age = value;   // this._age is implicit
        }

        // The usage of _age without 'this' is implicit
        // and refers to the private field _age of the current instance of the class
        // where the code is located

        #endregion

        #region Name - using properties

        private string _name;

        // Read/Write property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Readonly property
        public string Name2
        {
            get { return _name; }
        }

        #endregion

        #region Occupation - using auto-property

        // The compiler automatically generates the necessary code
        // for getting and setting the property's value
        public OccupationEnum Occupation { get; set; }

        #endregion

        #endregion

        public Person(int age)
        {
            Console.WriteLine("Constructor (default)");
            _age = age;
        }

        // The : this(age) part ensures that the constructor with a single parameter
        // is called, and then the additional code inside the constructor
        // with parameters is executed
        public Person(int age, string name, OccupationEnum occupation) : this(age)
        {
            Console.WriteLine("Constructor (parameters)");
            Name = name;
            Occupation = occupation;
        }

        // Copy constructor
        public Person(Person previousPerson)
            : this(previousPerson.GetAge(), previousPerson.Name, previousPerson.Occupation)
        {
            Console.WriteLine("Copy constructor");
        }

        // This copy constructor creates a new Person object
        // by copying values from an existing Person object (previousPerson)

        // Destructor
        ~Person()
        {
            Console.WriteLine("Destructor");
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Occupation: {2}",
                Name, _age, Occupation);
        }
    }
}
