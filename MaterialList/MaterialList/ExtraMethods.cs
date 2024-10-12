using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void SaveToCSV(Bom BomData, string filePath)
        {
            // Do the thing
            var bom = BomData;
            string customer = bom.Customer;
            string employee = bom.Employee;

            

        }

        public static Bom OpenCSV(string filePath)
        {
            Bom bom = new Bom();
            return bom;
        }
    }
}
