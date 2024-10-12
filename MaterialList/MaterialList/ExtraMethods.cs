using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialList
{
    public static class ExtraMethods
    {
        public static BindingList<Item> OpenCsv(string filePath)
        {
            //Read from the file path and put into an Item object
            BindingList<Item> items = new BindingList<Item>();

            using (StreamReader reader = new StreamReader(filePath))
            {                
                string headerLine = reader.ReadLine();

                string recordIn = reader.ReadLine();
                while (recordIn != null)
                {
                    string[] values = recordIn.Split(',');

                    Item item = new Item
                    {
                        ItemID = long.Parse(values[0]),
                        Name = values[1],
                        ItemCategory = Enum.Parse<Category>(values[2]),
                        Material = values[3],
                        Description = values[4],
                        UnitPrice = decimal.Parse(values[5], CultureInfo.InvariantCulture),
                    };

                    items.Add(item);

                    recordIn = reader.ReadLine();
                }
            }

            return items;
        }
    }
}
