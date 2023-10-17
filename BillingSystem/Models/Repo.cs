namespace BillingSystem.Models
{
    public class Repo
    {
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
