using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        public static List<Vendor> VendorList = new List<Vendor> { };

        public Vendor(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            VendorList.Add(this);
            Id = VendorList.Count;
        }

        public static List<Vendor> GetAll()
        {
            return VendorList;
        }


        public static Vendor Find(int searchId)
        {
            return VendorList[searchId - 1];
        }
    }
}