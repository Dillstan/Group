﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Random random = new Random();
            filePath += $@"\MaterialList_{DateTime.Now.ToString("yyyy-mm-dd_hh-mm-ss")}.csv";
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