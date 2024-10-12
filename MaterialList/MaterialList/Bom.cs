using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialList
{
    public class Bom
    {
        public Bom()
        {
            BomItems = new List<BomItem>();
        }

        public List<BomItem> BomItems
        {
            get; set;

        }
        public string Customer { get; set; }
        public string Employee { get; set; }

        public void SaveToCsv(string filePath)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                writer.WriteLine("ItemID,Name,Category,Material,Description,UnitPrice,Quantity,ExtPrice");

                
                foreach (var bomItem in BomItems)
                {
                    writer.WriteLine($"{bomItem.ItemID}," +
                                     $"{bomItem.Name}," +
                                     $"{bomItem.ItemCategory}," +
                                     $"{bomItem.Material}," +
                                     $"{bomItem.Description}," +
                                     $"{bomItem.UnitPrice}," +
                                     $"{bomItem.Quantity}," +
                                     $"{bomItem.ExtPrice}");
                }

            }
        }

        public List<BomItem> OpenCsv(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {

                string headerLine = reader.ReadLine();

                string recordIn = reader.ReadLine();
                while ((recordIn  != null))
                {
                    string[] values = recordIn.Split(',');

                    BomItem bomItem = new BomItem
                    {
                        ItemID = long.Parse(values[0]),
                        Name = values[1],
                        ItemCategory = Enum.Parse<Category>(values[2]),
                        Material = values[3],
                        Description = values[4],
                        UnitPrice = decimal.Parse(values[5], CultureInfo.InvariantCulture),
                        Quantity = int.Parse(values[6])
                    };

                    BomItems.Add(bomItem);
                }
            }

            return BomItems;
        }
    }
}