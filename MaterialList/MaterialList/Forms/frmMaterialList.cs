using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialList.Forms
{
    public partial class frmMaterialList : Form
    {
        private BindingList<ItemInfo> _Items = new BindingList<ItemInfo>() { };
        public frmMaterialList()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Run Calculations

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save to excel
            //Via interop?
            //Or Open XML package
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear List
            _Items.Clear();
        }

        private void frmMaterialList_Load(object sender, EventArgs e)
        {
            itemInfoBindingSource.DataSource = _Items;
        }

        private void itemInfoBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
         //   textBox1.Text = $"Total: {_Items.Select(x => x.ExtPrice).Sum()}";
        }
    }
}
