namespace BillingSystem.Models
{
    public class Commonview
    {
        public BillingAddressess BillingCreate { get; set; }

        public ShippingAddress ShippingCreate { get; set; }

        public AddProduct AddProduct { get; set; }
        public List<AddProduct> Cart {  get; set; }
    }
}
