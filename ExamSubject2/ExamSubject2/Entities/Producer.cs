using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject2.Entities
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Producer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
