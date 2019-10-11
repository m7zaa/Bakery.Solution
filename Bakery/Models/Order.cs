using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
    public class Order
    {
        public string OrderDescription { get; set; }
        public int Id { get; }
        // public List<Order> Orders { get; set; }
        public static List<Order> OrderList = new List<Order> { };


        public Order(string orderDescription)
        {
            OrderDescription = orderDescription;
            OrderList.Add(this);
            Id = OrderList.Count;
            // OrderList = new List<Order>{};

        }
        public static Order Find(int searchId)
        {
            return OrderList[searchId - 1];
        }

    }
}