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
        #region GetClipboardData

        private static String[] _LineSplit = new String[1] { Environment.NewLine };

        public static string[] SuperSplit(this string InputString, int MinimumFields, char delimiter = '\t')
        {
            string[] results = InputString.Split(delimiter);
            if (results.Length < MinimumFields)
                Array.Resize(ref results, MinimumFields);

            return results;
        }

        public static string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return String.Empty;

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return String.Empty;
            }
        }

        public static IEnumerable<string[]> ClipBoardDataParsed(int MinimumFields)
        {
            foreach (string line in ClipboardData.Split(_LineSplit, StringSplitOptions.RemoveEmptyEntries))
                yield return line.SuperSplit(MinimumFields, '\t');
        }
        #endregion

        //public static void SaveToCSV(Bom BomData, string filePath)
        //{
        //    // Do the thing

        //}

 
        // OpenCsv Method to read the CSV file and return a binding list of items to populate
        // the Material List.
        public static BindingList<Item> OpenCsv(string filePath)
        {
            BindingList<Item> items = new BindingList<Item>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // We dont need the header line so it is read but unused here. 
                string headerLine = reader.ReadLine();

                string recordIn = reader.ReadLine();
                while ((recordIn != null))
                {
                    string[] values = recordIn.Split(','); // split the line on '.' into an array of strings

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
