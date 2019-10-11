using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public string Description { get; set; }
        private static List<Item> _instances = new List<Item> { };

        public Order(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }


        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}