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
        private static List<AccessPackage> accessPackages;

        public Registration() { }
        public Registration(string companyName, int noOfPasses, int accessPackageId) : this()
        {
            CompanyName = companyName;
            NoOfPasses = noOfPasses;
            AccessPackageId = accessPackageId;
        }

        public static void SetAccessPackages(List<AccessPackage> packages)
        {
            accessPackages = packages;
        }

        public static explicit operator double(Registration registration)
        {
            var package = accessPackages.FirstOrDefault(p => p.Id == registration.AccessPackageId);
            return package != null ? package.Price * registration.NoOfPasses : 0.0;
        }
    }
}
