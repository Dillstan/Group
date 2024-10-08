using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialList
{
    public class Bom
    {
        public Bom()
        {
        }

        public List<BomItem> BomItems
        {
            get; set;

        }
        public string Customer { get; set; }
        public string Employee { get; set; }

    }
}