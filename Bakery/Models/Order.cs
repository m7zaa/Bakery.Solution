using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Models
{
    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDate { get; set; }
        public string OrderDescription { get; set; }
        public int OrderPrice { get; set; }
        public string CookieQuant { get; set; }
        public int CookieTotal { get; set; }
        public string BreadQuant { get; set; }
        public int BreadTotal { get; set; }

        public int Id { get; }
        public static List<Order> OrderList = new List<Order> { };

        public Order(string orderTitle, string orderDate, string orderDescription, string cookieQuant, string breadQuant)
        {
            OrderTitle = orderTitle;
            OrderDate = orderDate;
            OrderDescription = orderDescription;
            OrderPrice = 0;
            CookieQuant = cookieQuant;
            CookieTotal = 0;
            BreadQuant = breadQuant;
            BreadTotal = 0;
            OrderList.Add(this);
            Id = OrderList.Count;
        }

        public static Order Find(int searchId)
        {
            return OrderList[searchId - 1];
        }
        public static int BreadCost(int breadQuant, double breadTotal)
        {
            breadTotal = Math.Ceiling((double)breadQuant / 1.5) * 5;
            return (int)breadTotal;
        }

        public static int CookieCost(int cookieQuant, double cookieTotal)
        {
            cookieTotal = Math.Ceiling(((double)cookieQuant / 3) * 5);
            return (int)cookieTotal;
        }
    }
}