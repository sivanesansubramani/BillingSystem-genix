using System.Data.SqlClient;
using Dapper;

namespace BillingSystem.Models
{
    public class Repo
    {
        public readonly string connectionString;

        public Repo()
        {
            connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Billdata;Integrated Security=False;Connect Timeout=30;Encrypt=False";
        }

        public List<AddProduct> ListProduct()
        {
            try
            {
                List<AddProduct> constrain = new List<AddProduct>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<AddProduct>($"  exec List ").ToList();
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

        public AddProduct Getproduct(int No)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var product = connection.QueryFirst<AddProduct>($"  exec ListNo'{No}' ");
                con.Close();



                return product;


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

        public void InsertProduct(AddProduct pro)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec Selectproduct'{pro.Code}', '{pro.ProductName}','{pro.Quantity}','{pro.Unitprice}','{pro.Subtotal}'");

                con.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Delete(int No)
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec Deleteproduct {No}");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Cleans()
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec DeleteRecord");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

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



        /*public List<AddProduct> Selects()
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
        }*/
    }
}
