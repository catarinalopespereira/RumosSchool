using RumosSchool.Data.Repositories;
using RumosSchool.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Services.Services
{
    public class ProductService
    {

        private ProductRepository _repo;

        public ProductService()
        {
            _repo = new ProductRepository();
        }

        public List<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Product product)
        {
            if (product == null)
                throw new Exception("Impossível isto ser null");

            if (product.UnitPrice < 0)
                throw new Exception("Impossível haver preços abaixo de zero");

            product.Name = product.Name.Trim().Substring(0, 1).ToUpper() + product.Name.Trim().Substring(1).ToLower();

            _repo.Add(product);
        }

        public void Update(Product product)
        {
            _repo.Update(product);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

        public void CountProducts()
        {

        }

        public void ValidadeAccount()
        {
            


        }
    }
}
