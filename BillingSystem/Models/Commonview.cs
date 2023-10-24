
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
    public class Commonview
    {
        [Required]
        public BillingAddressess BillingCreate { get; set; }
        [Required]

        public ShippingAddress ShippingCreate { get; set; }
        [Required]

        public AddProduct AddProduct { get; set; }
        public List<AddProduct> Cart {  get; set; }

        public List<Dropdownmodels> ProductDrop { get; set; }

        public List<Total> Total { get; set; }





    }
}
