using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject3.Entities
{
    public class Participant : IComparable<Participant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> Concerts { get; set; }

        public Participant(int id, string name, string email, DateTime birthDate, List<string> concerts)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Concerts = concerts;
        }

        public static explicit operator int(Participant participant)
        {
            return participant.Concerts.Count;
        }

        public int CompareTo(Participant other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
