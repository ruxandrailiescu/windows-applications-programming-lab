using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject5
{
    [Serializable]
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Wage { get; set; }
        public int SpecialtyId { get; set; }

        public Doctor() { }

        public Doctor(int id, string name, DateTime birthDate, double wage, int specialtyId)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Wage = wage;
            SpecialtyId = specialtyId;
        }
    }
}
