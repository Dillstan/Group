using MaterialList;
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
        BindingList<ItemInfo> itemMaster = new BindingList<ItemInfo>();
        BindingList<ItemInfo> BomItems = new BindingList<ItemInfo>();


        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemInfo item = new ItemInfo();
            //TODO populate fields based on what is in combo boxes
            BomItems.Add(item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(BomItems != null || BomItems.Count > 0)
                BomItems.Remove((ItemInfo)itemInfoBindingSource.Current);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //TODO - Logic for export here, Scott
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO - update this too
            cmbPartNo.Items.AddRange(itemMaster.Where(x => x.Name == cmbClass.Text).Select(x => x.Name).ToArray());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //TODO - Add the new fields/item class
            foreach (var row in ExtraMethods.ClipBoardDataParsed(5))
            {
                ItemInfo item = new ItemInfo();
                item.Name = row[0];
                item.Description = row[1];
                if (int.TryParse(row[2], out int cost))
                    item.UnitPrice = cost;
                itemMaster.Add(item);
            }
            RefreshBindings();
        }

        private void btnClearlList_Click(object sender, EventArgs e)
        {
            itemMaster.Clear();
            RefreshBindings();
        }

        public void RefreshBindings()
        {
            //TODO - update to correct information
            itemInfoBindingSource.DataSource = BomItems;
            itemMasterBindingSource.DataSource = itemMaster;
            cmbPartNo.Items.Clear();
            cmbClass.Items.Clear();
            cmbClass.Items.AddRange(itemMaster.Select(x => x.Name).ToArray());
        }
    }
}
