using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal struct PersonStruct
    {
        // STRUCT = value type that is typically used to encapsulate small groups of related variables

        #region Attributes
        public int Age;
        public string Name;
        public OccupationEnum Occupation;
        #endregion

        // Constructor with parameters
        public PersonStruct(int age, string name, OccupationEnum occupation)
        {
            Age = age;
            Name = name;
            Occupation = occupation;
        }

        // Type "override ToString" and press Tab to generate this method
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Occupation: {2}", Name, Age, Occupation);
        }
    }
}
