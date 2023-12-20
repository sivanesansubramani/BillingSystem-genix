using Dapper;
using System.Data.SqlClient;

namespace BillingSystem.Models
{
    public class Total
    {
        public int  TotalAmount { get; set; }
        public readonly string connectionString;

        public Total()
        {
            connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Billdata;Integrated Security=False;Connect Timeout=30;Encrypt=False";
        }
        public List<Total> Totalamount()
        {
            try
            {
                List<Total> constrain = new List<Total>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<Total>($" exec Total ").ToList();
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
    }
}
