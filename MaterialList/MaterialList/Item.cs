using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Item class provides the base class for each item on the list of materials minus quantity and total price.
// BomItem class inherits from Item and adds quantity and total.

namespace MaterialList
{
    public class Item
    {
        public Item()
        {
        }
        
        public long ItemID { get; set; }    // Unique ID # that can be used as PK
        public string Name { get; set; }    // Item Name
        public Category ItemCategory { get; set; }
        public string Material { get; set; }    // Concrete, wood, steel, etc...
        public string Description { get; set; } // size or description
        public decimal UnitPrice { get; set; }
    }

    // Categories for items.
    public enum Category
    {
        Floor,
        Walls,
        Openings,
        Roof
    }
}