using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Interfaces
{
    internal interface IDeveloper
    {
        string[] Languages { get; set; }
        bool Knows(string language);
    }
}
