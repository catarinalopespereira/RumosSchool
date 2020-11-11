using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Model.Model
{
    public class Product : Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public Product()
        {
        }

        public Product(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"ID: {Id}; Name: {Name}; UnitPrice: {UnitPrice}";
        }
    }
}
