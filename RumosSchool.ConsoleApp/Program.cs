using RumosSchool.Model.Model;
using RumosSchool.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.ConsoleApp
{
    class Program
    {

        private static ProductService _service = new ProductService();

        static void Main(string[] args)
        {

            Product student = new Product()
            {
                Name = "iPad",
                UnitPrice = 1200
            };

            _service.Add(student); // INSERT

            Product prod = _service.GetById(1);
            prod.Name = "iPhone ";

            _service.Update(prod); // UPDATE






        }
    }
}
