using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{

    // Plant inherits the ItemNo, Description, and Price properties from the InvItem class,
    // showing inheritance because Plant is a specialized type of InvItem.
    public class Plant : InvItem
    {
        public string Size { get; set; }

        public Plant()
        {
            Size = "";
        }

        //Marley Chilenski
        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price)
        {
            Size = size;
        }

        //Marley Chilenski
        public override string GetDisplayText()
        {
            return ItemNo + " " + Size + " " + Description + " ($" + Price + ")";
        }
    }
}
