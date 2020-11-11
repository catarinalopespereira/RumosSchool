using RumosSchool.Model.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Data.Repositories
{
    public class ProductRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Products"].ConnectionString;
        private static int _colProductId = 0;
        private static int _colProductName = 1;
        private static int _colProductUnitPrice = 2;

        // Código ADO.NET

        public List<Product> GetAll()
        {
            List<Product> temp = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                string query = "SELECT * FROM Products";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = new Product();

                    product.Id = dr.GetInt32(_colProductId);
                    product.Name = dr.GetString(_colProductName);
                    product.UnitPrice = dr.GetDecimal(_colProductUnitPrice);

                    temp.Add(product);
                }
            }

            return temp;
        }

        public Product GetById(int id)
        {

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                string query = $"SELECT * FROM Product WHERE ProductId = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = new Product()
                    {
                        Id = dr.GetInt32(_colProductId),
                        Name = dr.GetString(_colProductName),
                        UnitPrice = dr.GetDecimal(_colProductUnitPrice)
                    };

                    return product;
                }
            }

            throw new Exception("Não existe nenhum produto com id: " + id);
        }

        public void Add(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                string query = $"INSERT INTO Products " +
                               $"VALUES (@prodName, @prodUnitPrice);" +
                               $"SELECT cast(Scope_Identity() as int);";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@prodName";
                nameParam.Value = product.Name;
                nameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter unitPriceParam = new SqlParameter();
                unitPriceParam.ParameterName = "@prodUnitPrice";
                unitPriceParam.Value = product.UnitPrice;
                unitPriceParam.Direction = ParameterDirection.Input;
                unitPriceParam.SqlDbType = SqlDbType.Decimal;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.Add(unitPriceParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                product.Id = id;
            }
        }

        public void Update(Product Product)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
