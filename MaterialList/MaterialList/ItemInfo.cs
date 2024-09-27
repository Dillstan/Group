using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialList
{
    public class ItemInfo
    {
        public ItemInfo()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtPrice { get { return UnitPrice * Quantity; } }
    }
}
