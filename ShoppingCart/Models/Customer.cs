using System.Collections.Generic;

namespace ShoppingCart.Models {
    public class Customer  {
        public Customer() {
            Orders = new List<Order>();
        }

        public int CustomerId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}
