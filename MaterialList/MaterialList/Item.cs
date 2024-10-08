using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialList
{
    public class Item
    {
        public Item()
        {
        }

        public long ItemID { get; set; }
        public string Name { get; set; }
        public Category ItemCategory { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public enum Category
    {
        Floor,
        Walls,
        Openings,
        Roof
    }
}









/*using System;
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
*/