using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDate { get; set; }
        public string OrderDescription { get; set; }
        public int OrderPrice { get; set; }

        public int Id { get; }
        // public List<Order> Orders { get; set; }
        public static List<Order> OrderList = new List<Order> { };


        public Order(string orderTitle, string orderDate, string orderDescription)
        {
            OrderTitle = orderTitle;
            OrderDate = orderDate;
            OrderDescription = orderDescription;
            OrderPrice = 0;
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