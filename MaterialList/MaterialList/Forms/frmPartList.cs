﻿using MaterialList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MaterialList
{
    public partial class frmBOM : Form
    {
        //Form Variables
        private BindingList<Item> itemMaster = new BindingList<Item>();
        private BindingList<BomItem> bomItems = new BindingList<BomItem>();

        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {
            RefreshBindings();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create new BomItem
            var bomItem = new BomItem();

            if (bomItem == null)
                return;

            Enum.TryParse(typeof(Category), cmbCategory.Text, true, out object? cat);

            if (cat == null)
                return;

            var category = (Category)cat;
            if (!long.TryParse(cmbPartNo.Text, out long i))
                return;
            var item = itemMaster.Where(x => x.ItemID == i && x.ItemCategory == category).FirstOrDefault();

            bomItem.ItemID = item.ItemID;
            bomItem.ItemCategory = item.ItemCategory;
            bomItem.Material = item.Material;
            bomItem.UnitPrice = item.UnitPrice;
            bomItem.Description = item.Description;
            bomItem.Name = item.Name;
            int.TryParse(txtQuantity.Text, out int quantity);
            bomItem.Quantity = quantity;

            bomItems.Add(bomItem);

            grdBom.Refresh();

            cmbCategory.Text = "";
            cmbPartNo.Text = "";
            txtQuantity.Text = "";

            txtTotal.Text = "$" + bomItems.Select(x => x.ExtPrice).Sum().ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Confirm edit
            DialogResult dlgRes = MessageBox.Show("Are you sure you would like to update the selected row", "Update Confirm", MessageBoxButtons.YesNo);

            if (dlgRes == DialogResult.No) return;

            //Edit current item
            var bomItem = (BomItem)itemInfoBindingSource.Current;
            if (bomItem == null)
                return;

            Enum.TryParse(typeof(Category), cmbCategory.Text, true, out object? cat);

            if (cat == null)
                return;

            var category = (Category)cat;
            if (!long.TryParse(cmbPartNo.Text, out long i))
                return;
            var item = itemMaster.Where(x => x.ItemID == i && x.ItemCategory == category).FirstOrDefault();

            bomItem.ItemID = item.ItemID;
            bomItem.ItemCategory = item.ItemCategory;
            bomItem.Material = item.Material;
            bomItem.UnitPrice = item.UnitPrice;
            bomItem.Description = item.Description;
            bomItem.Name = item.Name;
            int.TryParse(txtQuantity.Text, out int quantity);
            bomItem.Quantity = quantity;

            grdBom.Refresh();

            cmbCategory.Text = "";
            cmbPartNo.Text = "";
            txtQuantity.Text = "";

            //sum the ext price
            txtTotal.Text = "$" + bomItems.Select(x => x.ExtPrice).Sum().ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //confirm delete
            DialogResult dlgRes = MessageBox.Show("Are you sure you would like to delete the selected row", "Delete Confirm", MessageBoxButtons.YesNo);
            if (dlgRes == DialogResult.No) return;

            //delete selected item
            if (bomItems != null || bomItems.Count > 0)
                bomItems.Remove((BomItem)itemInfoBindingSource.Current);

            if (bomItems != null || bomItems.Count > 0)
                txtTotal.Text = "$" + bomItems.Select(x => x.Quantity).Sum().ToString();
            else
                txtTotal.Text = "$0";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //export to a CSV file
            using (FolderBrowserDialog matl = new FolderBrowserDialog())
            {
                if (matl.ShowDialog() == DialogResult.OK)
                {
                    //Create Bom to send to method
                    Bom mainBom = new Bom();
                    mainBom.Customer = "Test Customer";
                    mainBom.Employee = "Dat Employee";
                    mainBom.BomItems = bomItems.ToList();
                    mainBom.SaveToCsv(matl.SelectedPath);
                }
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show the parts for the category
            cmbPartNo.Items.Clear();
            cmbPartNo.Text = "";
            var x = itemMaster.Where(x => x.ItemCategory == (Category)Enum.Parse(typeof(Category), cmbCategory.Text)).Select(x => x.ItemID.ToString()).Distinct();
            cmbPartNo.Items.AddRange(x.ToArray());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //get file
            using (OpenFileDialog matl = new OpenFileDialog())
            {
                if (matl.ShowDialog() == DialogResult.OK)
                {
                    string filePath = matl.FileName;
                    lblPath.Text = filePath;
                }
            }

            //set item master and refresh bindings
            itemMaster = ExtraMethods.OpenCsv(lblPath.Text);

            RefreshBindings();
        }

        private void btnClearlList_Click(object sender, EventArgs e)
        {
            //clear and refresh the item master
            itemMaster.Clear();
            RefreshBindings();
        }

        public void RefreshBindings()
        {
            //Refresh everything
            itemInfoBindingSource.DataSource = bomItems;
            itemMasterBindingSource.DataSource = itemMaster;
            cmbPartNo.Items.Clear();
            cmbCategory.Items.Clear();
            cmbPartNo.Text = "";
            cmbCategory.Text = "";
            cmbCategory.Items.AddRange(itemMaster.Select(x => x.ItemCategory.ToString()).Distinct().ToArray());
        }

        private void btnClearBom_Click(object sender, EventArgs e)
        {
            //confirm clear
            DialogResult dlgRes = MessageBox.Show("Are you sure you would like to clear the current BOM?", "Clear Confirm", MessageBoxButtons.YesNo);
            if (dlgRes == DialogResult.No) return;

            //do the clear
            bomItems.Clear();
            txtTotal.Text = "$0";
        }
    }
}
