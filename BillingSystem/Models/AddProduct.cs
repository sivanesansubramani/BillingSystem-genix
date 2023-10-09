using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
    public class AddProduct
    {
        public int No { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Unitprice { get; set; }
        public int Subtotal { get; set; }

    }
}
