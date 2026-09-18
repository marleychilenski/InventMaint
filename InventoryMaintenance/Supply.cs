using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public string Manufacturer { get; set; }

        // Marley Chilenski
        public Supply()
        {
            Manufacturer = "";
        }
        // Marley Chilenski
        public Supply(int itemNo, string description, decimal price, string manufacturer)
            : base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }
        // Marley Chilenski
        public override string GetDisplayText()
        {
            return ItemNo + " " + Manufacturer + " " + Description + " ($" + Price + ")";
        }
    }
}
