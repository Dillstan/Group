using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BomItem Class extends Item to include Quantity and ExtPrice as well as unimplemented Alternates which
// could be used to chose alternate items to substitute for the current item object if it is unsuitable or 
// unavailable.
namespace MaterialList
{
    public class BomItem : Item
    {
        private List<Item> alternates;

        public BomItem()
        {
        }


        public int Quantity { get; set; }
        public List<Item> Alternates { get => alternates; set => alternates = value; }

        public decimal ExtPrice { get { return UnitPrice * Quantity; } }
    }
}