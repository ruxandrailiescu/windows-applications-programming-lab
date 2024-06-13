using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.Entities
{
    [Serializable]
    public class Participant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value >= DateTime.Today)
                    throw new InvalidBirthDateException(value);
                _birthDate = value;
            }
        }

        public GenderEnum Gender { get; set; }
        public string SSN { get; set; }

        // Constructors
        public Participant() { }

        public Participant(string lastName, string firstName, DateTime birthDate,
            GenderEnum gender, string ssn)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Gender = gender;
            SSN = ssn;
        }
    }
}
