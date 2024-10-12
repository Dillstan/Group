using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bom Class makes up the base for the material list.  Each Bom instance contains a List of BomItems
// a Customer and Employee property for the application users as well as a method for saving the file
// to CSV
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

        // Save the BOM file, takes a path to save the file to.  Writes BomItem properties on the top line
        // then cycles through each item in the List adding each formatted line to the file.
        public void SaveToCsv(string filePath)
        {
            filePath += $@"\MaterialList.csv";
            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)))
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


    }
}