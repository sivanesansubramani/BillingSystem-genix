using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
    public class AddProduct
    {
       
        public int No { get; set; }
        public string Code { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Unitprice { get; set; }
        public int Subtotal => Quantity * Unitprice;

        public int Total { get; set; }



    }
}
