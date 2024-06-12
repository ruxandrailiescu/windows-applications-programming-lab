using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Entities
{
    internal class Manager : Employee
    {
        #region Methods
        public new void PrintWageNormal()
        {
            Console.WriteLine("Manager - PrintWageNormal");
        }

        public override void PrintWageVirtual()
        {
            Console.WriteLine("Manager - PrintWageVirtual");
        }

        public override void PrintWageAbstract()
        {
            Console.WriteLine("Manager - PrintWageAbstract");
        }

        #endregion

        public Manager(string name) : base(name) { }
    }
}
