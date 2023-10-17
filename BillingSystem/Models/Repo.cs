using System.Data.SqlClient;
using Dapper;

namespace BillingSystem.Models
{
    public class Repo
    {
        public readonly string connectionString;

        public Repo()
        {
            connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BillingSystem;Integrated Security=False;Connect Timeout=30;Encrypt=False";
        }

        public List<AddProduct> ListProduct()
        {
            try
            {
                List<AddProduct> constrain = new List<AddProduct>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<AddProduct>($" exec GetproductNo ").ToList();
                connection.Close();

                return constrain;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public List<AddProduct> Selects()
        {
            var result = new List<AddProduct>();
            var firstproduct = new AddProduct();
            firstproduct.No = 1;
            firstproduct.Code = "DEL1109";
            firstproduct.ProductName = "DELL";
            firstproduct.Quantity = "1";
            firstproduct.Unitprice = 25000;
            firstproduct.Subtotal = 25000;

            result.Add(firstproduct);

            return result;
        }
    }
}
