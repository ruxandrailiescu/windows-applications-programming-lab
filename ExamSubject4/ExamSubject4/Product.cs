using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSubject4
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Units { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public Product(int id, string name, int units, double price, int categoryId)
        {
            Id = id;
            Name = name;
            Units = units;
            Price = price;
            CategoryId = categoryId;
        }

        public static explicit operator double(Product product)
        {
            return product.Price * product.Units;
        }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
