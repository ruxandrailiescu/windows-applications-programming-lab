using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.Entities
{
    public class InvalidBirthDateException : Exception  // inherits from Exception class
                                                        // InvalidBirthDateException is a type of exception
    {
        public DateTime BirthDate { get; set; }

        // Constructor
        public InvalidBirthDateException(DateTime birthDay)
        {
            BirthDate = birthDay;
        }

        // Override the Message property inherited from the Exception class
        // By overriding it, we can provide a custom message for our InvalidBirthDateException
        public override string Message
        {
            get
            {
                return "The birthDate " + BirthDate + " is invalid";
            }
        }
    }
}
