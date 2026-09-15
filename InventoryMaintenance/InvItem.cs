using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Marley Chilenski
    // This class demonstrates encapsulation by keeping the item's
    // data inside the class and controlling access through properties
    // and methods.
    public class InvItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Marley Chilenski
        // This constructor creates an InvItem with default values.
        public InvItem()
        {
            ItemNo = 0;
            Description = "";
            Price = 0m;
        }

        // Marley Chilenski
        // This constructor creates an InvItem with the specified
        // item number, description, and price.
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        // Marley Chilenski
        // This method returns the item's number, description,
        // and price in the required display format.
        public string GetDisplayText()
        {
            return $"{ItemNo} {Description} ({Price:C2})";
        }
    }
}
