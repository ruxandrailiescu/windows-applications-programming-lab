﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject1.Entities
{
    [Serializable]
    public class AccessPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        // Parameterless constructor for XML serialization
        public AccessPackage() { }

        public AccessPackage(int id, string name, double price) : this()
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
