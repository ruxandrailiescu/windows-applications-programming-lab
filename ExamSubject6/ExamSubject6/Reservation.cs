using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject6
{
    [Serializable]
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Persons { get; set; }
        public int RoomId { get; set; }

        public Reservation() { }

        public Reservation(int id, DateTime checkInDate, DateTime checkOutDate, int persons, int roomId)
        {
            Id = id;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Persons = persons;
            RoomId = roomId;
        }
    }
}
