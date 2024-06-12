using Lab03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Entities
{
    internal class SoftwareDeveloper : Employee, IDeveloper
    {
        #region Methods

        public new void PrintWageNormal()
        {
            Console.WriteLine("SoftwareDeveloper - PrintWageNormal");
        }

        public override void PrintWageVirtual()
        {
            Console.WriteLine("SoftwareDeveloper - PrintWageVirtual");
        }

        public override void PrintWageAbstract()
        {
            Console.WriteLine("SoftwareDeveloper - PrintWageAbstract");
        }

        #endregion

        #region IDeveloper
        public string[] Languages { get; set; }

        public bool Knows(string language)
        {
            return Languages.Contains(language);
        }

        #endregion

        public SoftwareDeveloper(string name) : base(name) { }
    }
}
