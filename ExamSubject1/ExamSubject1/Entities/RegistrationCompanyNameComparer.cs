using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject1.Entities
{
    public class RegistrationCompanyNameComparer : IComparer<Registration>
    {
        public int Compare(Registration x, Registration y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            return string.Compare(x.CompanyName, y.CompanyName);
        }
    }
}
