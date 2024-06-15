using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject6
{
    public class ReservationComparerCheckIn : IComparer<Reservation>
    {
        public int Compare(Reservation x, Reservation y)
        {
            return x.CheckInDate.CompareTo(y.CheckInDate);
        }
    }
}
