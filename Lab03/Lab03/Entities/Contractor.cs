using Lab03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Entities
{
    internal class Contractor : Person, IDeveloper
    {
        #region IDeveloper
        
        public string[] Languages { get; set; }

        public bool Knows(string language)
        {
            return Languages.Contains(language);
        }

        #endregion

        public Contractor(string name) : base(name) { }
    }
}
