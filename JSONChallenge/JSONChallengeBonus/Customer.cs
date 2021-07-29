using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.JSONChallengeBonus
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        public string Address { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

    }
    public class OrderAndPurchase
    {
        public string OrderId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

    public class Items
    {

    }
}
