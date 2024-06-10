using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject1.Entities
{
    public class Registration
    {
        public string CompanyName { get; set; }
        public int NoOfPasses { get; set; }
        public int AccessPackageId { get; set; }

        public Registration() { }
        public Registration(string companyName, int noOfPasses, int accessPackageId) : this()
        {
            CompanyName = companyName;
            NoOfPasses = noOfPasses;
            AccessPackageId = accessPackageId;
        }
    }
}
