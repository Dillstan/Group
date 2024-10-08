using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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