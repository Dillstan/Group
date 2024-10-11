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
using Microsoft.Office.Interop.Excel;


namespace MaterialList
{
    public partial class frmBOM : Form
    {
        BindingList<Item> itemMaster = new BindingList<Item>();
        BindingList<BomItem> BomItems = new BindingList<BomItem>();


        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BomItems != null || BomItems.Count > 0)
                BomItems.Remove((BomItem)itemInfoBindingSource.Current);
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
            /*foreach (var row in ExtraMethods.ClipBoardDataParsed(5))
            {
                ItemInfo item = new ItemInfo();
                item.Name = row[0];
                item.Description = row[1];
                if (int.TryParse(row[2], out int cost))
                    item.UnitPrice = cost;
                itemMaster.Add(item);
            }
            RefreshBindings();*/

            using (OpenFileDialog matl = new OpenFileDialog())
            {
                matl.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (matl.ShowDialog() == DialogResult.OK)
                {
                    string filePath = matl.FileName;
                    lblPath.Text = filePath;
                }
            }

            PartList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            grdItems.Rows.Clear();
        }

        //Exiting the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
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


        //Using the form this will open the excel application, open the workbook that was opened from the dialog window, select everything on the sheet1, and then add it to the data grid
        public void PartList()
        {
            Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;

            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(lblPath.Text);
                xlworksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                grdItems.ColumnCount = xlrange.Columns.Count;

                //Adding the header rows and populating the data
                for (int xlrow = 1; xlrow < xlrange.Rows.Count; xlrow++)
                {
                    Item newItem = new Item();
                    //grdItems.Rows.Add(xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text);

                    if (Enum.TryParse(xlrange.Cells[xlrow, 0].ToString(), out Category cat))
                    {
                        newItem.ItemCategory = cat;
                        long.TryParse(xlrange.Cells[xlrow, 1].ToString(), out long id);
                        newItem.ItemID = id;
                        newItem.Material = xlrange.Cells[xlrow, 2].ToString();
                        newItem.Description = xlrange.Cells[xlrow, 3].ToString();
                        decimal.TryParse(xlrange.Cells[xlrow, 4].ToString(), out decimal price);
                        newItem.UnitPrice = price;
                        itemMaster.Add(newItem);
                    }
                }

                //Closing the workbook and the excel application
                //xlworkbook.Close();
                xlapp.Quit();

            }
            //Showing any error messages
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
