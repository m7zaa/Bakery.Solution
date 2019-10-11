using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public string Description { get; set; }


        public Order(string description)
        {
            Description = description;
            //Add to Vendor1.orders
            // Order.Add(this);
        }


    }
}