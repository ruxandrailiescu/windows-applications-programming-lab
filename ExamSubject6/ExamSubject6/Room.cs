using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject6
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Beds { get; set; }

        public Room(int id, int number, int beds)
        {
            Id = id;
            Number = number;
            Beds = beds;
        }

        public static Room operator ++(Room room)
        {
            room.Beds++;
            return room;
        }

        public override string ToString()
        {
            return string.Format($"Id: {Id}, Number: {Number}, Beds: {Beds}");
        }
    }
}
