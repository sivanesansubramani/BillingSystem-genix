using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
    public class BillingAddressess
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public String Address { get; set; }
        [Required(ErrorMessage = "Address 2 is required")]
       public string Address2 { get; set; }
        [Required(ErrorMessage = "City is required")]
        public String City { get; set; }
        [Required(ErrorMessage = "State is required")]
        public String State { get; set; }
        [Required(ErrorMessage = "ContactNo is required")]
        [RegularExpression(@"^[0-9]{10}$")]
        public string ContactNo { get; set; }
    }
}
