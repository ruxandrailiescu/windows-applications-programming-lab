using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject6
{
    public class ReservationComparerPersons : IComparer<Reservation>
    {
        public int Compare(Reservation x, Reservation y)
        {
            return x.Persons.CompareTo(y.Persons);
        }
    }
}
