using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }
        public static List<Vendor> VendorList = new List<Vendor> { };

        public Vendor(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            VendorList.Add(this);
            Id = VendorList.Count;
            Orders = new List<Order>{};
        }

        public static List<Vendor> GetAll()
        {
            return VendorList;
        }

        public static Vendor Find(int searchId)
        {
            return VendorList[searchId - 1];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}