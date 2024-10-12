
namespace MaterialList
{
    partial class frmBOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            appPartLIst = new TabControl();
            tbBOM = new TabPage();
            grdBom = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemInfoBindingSource = new BindingSource(components);
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblPartNo = new Label();
            cmbPartNo = new ComboBox();
            lblClass = new Label();
            cmbCategory = new ComboBox();
            btnPrint = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            tabItemMaster = new TabPage();
            lblPath = new Label();
            grdItems = new DataGridView();
            itemIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            itemCategoryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            itemMasterBindingSource = new BindingSource(components);
            btnClearlList = new Button();
            btnImport = new Button();
            appPartLIst.SuspendLayout();
            tbBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdBom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).BeginInit();
            tabItemMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemMasterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // appPartLIst
            // 
            appPartLIst.Controls.Add(tbBOM);
            appPartLIst.Controls.Add(tabItemMaster);
            appPartLIst.Location = new Point(14, 14);
            appPartLIst.Margin = new Padding(4, 3, 4, 3);
            appPartLIst.Name = "appPartLIst";
            appPartLIst.SelectedIndex = 0;
            appPartLIst.Size = new Size(905, 492);
            appPartLIst.TabIndex = 0;
            // 
            // tbBOM
            // 
            tbBOM.Controls.Add(grdBom);
            tbBOM.Controls.Add(txtQuantity);
            tbBOM.Controls.Add(lblQuantity);
            tbBOM.Controls.Add(lblPartNo);
            tbBOM.Controls.Add(cmbPartNo);
            tbBOM.Controls.Add(lblClass);
            tbBOM.Controls.Add(cmbCategory);
            tbBOM.Controls.Add(btnPrint);
            tbBOM.Controls.Add(btnDelete);
            tbBOM.Controls.Add(btnEdit);
            tbBOM.Controls.Add(btnAdd);
            tbBOM.Location = new Point(4, 24);
            tbBOM.Margin = new Padding(4, 3, 4, 3);
            tbBOM.Name = "tbBOM";
            tbBOM.Padding = new Padding(4, 3, 4, 3);
            tbBOM.Size = new Size(897, 464);
            tbBOM.TabIndex = 0;
            tbBOM.Text = "BOM";
            tbBOM.UseVisualStyleBackColor = true;
            // 
            // grdBom
            // 
            grdBom.AllowUserToAddRows = false;
            grdBom.AllowUserToDeleteRows = false;
            grdBom.AutoGenerateColumns = false;
            grdBom.BackgroundColor = SystemColors.ControlLight;
            grdBom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBom.Columns.AddRange(new DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, extPriceDataGridViewTextBoxColumn, itemIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, itemCategoryDataGridViewTextBoxColumn, materialDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn });
            grdBom.DataSource = itemInfoBindingSource;
            grdBom.Location = new Point(8, 173);
            grdBom.Name = "grdBom";
            grdBom.ReadOnly = true;
            grdBom.RowHeadersWidth = 51;
            grdBom.RowTemplate.Height = 25;
            grdBom.Size = new Size(882, 285);
            grdBom.TabIndex = 11;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // extPriceDataGridViewTextBoxColumn
            // 
            extPriceDataGridViewTextBoxColumn.DataPropertyName = "ExtPrice";
            extPriceDataGridViewTextBoxColumn.HeaderText = "ExtPrice";
            extPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            extPriceDataGridViewTextBoxColumn.Name = "extPriceDataGridViewTextBoxColumn";
            extPriceDataGridViewTextBoxColumn.ReadOnly = true;
            extPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            itemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory";
            itemCategoryDataGridViewTextBoxColumn.HeaderText = "ItemCategory";
            itemCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            itemCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            itemCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            materialDataGridViewTextBoxColumn.HeaderText = "Material";
            materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            materialDataGridViewTextBoxColumn.ReadOnly = true;
            materialDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemInfoBindingSource
            // 
            itemInfoBindingSource.DataSource = typeof(BomItem);
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(103, 115);
            txtQuantity.Margin = new Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(116, 23);
            txtQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(41, 123);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // lblPartNo
            // 
            lblPartNo.AutoSize = true;
            lblPartNo.Location = new Point(19, 93);
            lblPartNo.Margin = new Padding(4, 0, 4, 0);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(75, 15);
            lblPartNo.TabIndex = 8;
            lblPartNo.Text = "Part Number";
            // 
            // cmbPartNo
            // 
            cmbPartNo.FormattingEnabled = true;
            cmbPartNo.Location = new Point(102, 85);
            cmbPartNo.Margin = new Padding(4, 3, 4, 3);
            cmbPartNo.Name = "cmbPartNo";
            cmbPartNo.Size = new Size(238, 23);
            cmbPartNo.TabIndex = 7;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(15, 61);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(79, 15);
            lblClass.TabIndex = 6;
            lblClass.Text = "Part Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(103, 53);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(140, 23);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(293, 8);
            btnPrint.Margin = new Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(88, 27);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Export to CSV";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(197, 8);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(103, 8);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 27);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 8);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabItemMaster
            // 
            tabItemMaster.Controls.Add(lblPath);
            tabItemMaster.Controls.Add(grdItems);
            tabItemMaster.Controls.Add(btnClearlList);
            tabItemMaster.Controls.Add(btnImport);
            tabItemMaster.Location = new Point(4, 24);
            tabItemMaster.Margin = new Padding(4, 3, 4, 3);
            tabItemMaster.Name = "tabItemMaster";
            tabItemMaster.Padding = new Padding(4, 3, 4, 3);
            tabItemMaster.Size = new Size(897, 464);
            tabItemMaster.TabIndex = 1;
            tabItemMaster.Text = "Item Master";
            tabItemMaster.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(199, 15);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(75, 15);
            lblPath.TabIndex = 13;
            lblPath.Text = "\\\\C:\\FilePath";
            // 
            // grdItems
            // 
            grdItems.AllowUserToAddRows = false;
            grdItems.AllowUserToDeleteRows = false;
            grdItems.AutoGenerateColumns = false;
            grdItems.BackgroundColor = SystemColors.ControlLight;
            grdItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItems.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn1, dataGridViewTextBoxColumn9, itemCategoryDataGridViewTextBoxColumn1, materialDataGridViewTextBoxColumn1, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            grdItems.DataSource = itemMasterBindingSource;
            grdItems.Location = new Point(7, 42);
            grdItems.Name = "grdItems";
            grdItems.ReadOnly = true;
            grdItems.RowHeadersWidth = 51;
            grdItems.RowTemplate.Height = 25;
            grdItems.Size = new Size(882, 416);
            grdItems.TabIndex = 12;
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            itemIDDataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn1.HeaderText = "ItemID";
            itemIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            itemIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            dataGridViewTextBoxColumn9.HeaderText = "Name";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // itemCategoryDataGridViewTextBoxColumn1
            // 
            itemCategoryDataGridViewTextBoxColumn1.DataPropertyName = "ItemCategory";
            itemCategoryDataGridViewTextBoxColumn1.HeaderText = "ItemCategory";
            itemCategoryDataGridViewTextBoxColumn1.MinimumWidth = 6;
            itemCategoryDataGridViewTextBoxColumn1.Name = "itemCategoryDataGridViewTextBoxColumn1";
            itemCategoryDataGridViewTextBoxColumn1.ReadOnly = true;
            itemCategoryDataGridViewTextBoxColumn1.Width = 125;
            // 
            // materialDataGridViewTextBoxColumn1
            // 
            materialDataGridViewTextBoxColumn1.DataPropertyName = "Material";
            materialDataGridViewTextBoxColumn1.HeaderText = "Material";
            materialDataGridViewTextBoxColumn1.MinimumWidth = 6;
            materialDataGridViewTextBoxColumn1.Name = "materialDataGridViewTextBoxColumn1";
            materialDataGridViewTextBoxColumn1.ReadOnly = true;
            materialDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Description";
            dataGridViewTextBoxColumn10.HeaderText = "Description";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "UnitPrice";
            dataGridViewTextBoxColumn11.HeaderText = "UnitPrice";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // itemMasterBindingSource
            // 
            itemMasterBindingSource.DataSource = typeof(Item);
            // 
            // btnClearlList
            // 
            btnClearlList.Location = new Point(103, 8);
            btnClearlList.Margin = new Padding(4, 3, 4, 3);
            btnClearlList.Name = "btnClearlList";
            btnClearlList.Size = new Size(88, 27);
            btnClearlList.TabIndex = 2;
            btnClearlList.Text = "Clear List";
            btnClearlList.UseVisualStyleBackColor = true;
            btnClearlList.Click += btnClearlList_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(7, 9);
            btnImport.Margin = new Padding(4, 3, 4, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(88, 27);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // frmBOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(appPartLIst);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBOM";
            Text = "Bill of Material";
            Load += frmBOM_Load;
            appPartLIst.ResumeLayout(false);
            tbBOM.ResumeLayout(false);
            tbBOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdBom).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).EndInit();
            tabItemMaster.ResumeLayout(false);
            tabItemMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemMasterBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl appPartLIst;
        private TabPage tbBOM;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblPartNo;
        private ComboBox cmbPartNo;
        private Label lblClass;
        private ComboBox cmbCategory;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnAdd;
        private TabPage tabItemMaster;
        private Button btnClearlList;
        private Button btnImport;
        private DataGridView grdBom;
        private BindingSource itemInfoBindingSource;
        private DataGridView grdItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource itemMasterBindingSource;
        private Label lblPath;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn extPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private Button btnEdit;
    }
}

