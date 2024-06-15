using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject5
{
    public class DoctorComparerName : IComparer<Doctor>
    {
        public int Compare(Doctor x, Doctor y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
