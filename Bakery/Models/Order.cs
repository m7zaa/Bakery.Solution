using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
    public class Order
    {
        public string Description { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }
        public static List<Order> OrderList = new List<Order> { };


        public Order(string description)
        {
            Description = description;
            Id = OrderList.Count;
            OrderList = new List<Order>{};

            //Add to Vendor1.orders
            // Order.Add(this);
        }
        public static Order Find(int searchId)
        {
            return OrderList[searchId - 1];
        }

    }
}