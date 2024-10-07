
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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemInfoBindingSource = new BindingSource(components);
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblPartNo = new Label();
            cmbPartNo = new ComboBox();
            lblClass = new Label();
            cmbClass = new ComboBox();
            btnPrint = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            tabItemMaster = new TabPage();
            grdItems = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
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
            appPartLIst.Location = new Point(16, 19);
            appPartLIst.Margin = new Padding(5, 4, 5, 4);
            appPartLIst.Name = "appPartLIst";
            appPartLIst.SelectedIndex = 0;
            appPartLIst.Size = new Size(1034, 656);
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
            tbBOM.Controls.Add(cmbClass);
            tbBOM.Controls.Add(btnPrint);
            tbBOM.Controls.Add(btnDelete);
            tbBOM.Controls.Add(btnEdit);
            tbBOM.Controls.Add(btnAdd);
            tbBOM.Location = new Point(4, 29);
            tbBOM.Margin = new Padding(5, 4, 5, 4);
            tbBOM.Name = "tbBOM";
            tbBOM.Padding = new Padding(5, 4, 5, 4);
            tbBOM.Size = new Size(1026, 623);
            tbBOM.TabIndex = 0;
            tbBOM.Text = "BOM";
            tbBOM.UseVisualStyleBackColor = true;
            // 
            // grdBom
            // 
            grdBom.AutoGenerateColumns = false;
            grdBom.BackgroundColor = SystemColors.ControlLight;
            grdBom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBom.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, extPriceDataGridViewTextBoxColumn });
            grdBom.DataSource = itemInfoBindingSource;
            grdBom.Location = new Point(9, 231);
            grdBom.Margin = new Padding(3, 4, 3, 4);
            grdBom.Name = "grdBom";
            grdBom.RowHeadersWidth = 51;
            grdBom.RowTemplate.Height = 25;
            grdBom.Size = new Size(1008, 380);
            grdBom.TabIndex = 11;
            grdBom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.Width = 125;
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
            // itemInfoBindingSource
            // 
            itemInfoBindingSource.DataSource = typeof(ItemInfo);
            // 
            // txtQuantity
            // 
            txtQuantity.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Quantity", true));
            txtQuantity.Location = new Point(118, 153);
            txtQuantity.Margin = new Padding(5, 4, 5, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(132, 27);
            txtQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(47, 164);
            lblQuantity.Margin = new Padding(5, 0, 5, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // lblPartNo
            // 
            lblPartNo.AutoSize = true;
            lblPartNo.Location = new Point(22, 124);
            lblPartNo.Margin = new Padding(5, 0, 5, 0);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(92, 20);
            lblPartNo.TabIndex = 8;
            lblPartNo.Text = "Part Number";
            // 
            // cmbPartNo
            // 
            cmbPartNo.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Name", true));
            cmbPartNo.FormattingEnabled = true;
            cmbPartNo.Location = new Point(117, 113);
            cmbPartNo.Margin = new Padding(5, 4, 5, 4);
            cmbPartNo.Name = "cmbPartNo";
            cmbPartNo.Size = new Size(271, 28);
            cmbPartNo.TabIndex = 7;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(17, 81);
            lblClass.Margin = new Padding(5, 0, 5, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(98, 20);
            lblClass.TabIndex = 6;
            lblClass.Text = "Part Category";
            // 
            // cmbClass
            // 
            cmbClass.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Description", true));
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(118, 71);
            cmbClass.Margin = new Padding(5, 4, 5, 4);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(159, 28);
            cmbClass.TabIndex = 5;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(335, 11);
            btnPrint.Margin = new Padding(5, 4, 5, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 36);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(225, 11);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(118, 11);
            btnEdit.Margin = new Padding(5, 4, 5, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 11);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabItemMaster
            // 
            tabItemMaster.Controls.Add(grdItems);
            tabItemMaster.Controls.Add(btnClearlList);
            tabItemMaster.Controls.Add(btnImport);
            tabItemMaster.Location = new Point(4, 29);
            tabItemMaster.Margin = new Padding(5, 4, 5, 4);
            tabItemMaster.Name = "tabItemMaster";
            tabItemMaster.Padding = new Padding(5, 4, 5, 4);
            tabItemMaster.Size = new Size(1026, 623);
            tabItemMaster.TabIndex = 1;
            tabItemMaster.Text = "Item Master";
            tabItemMaster.UseVisualStyleBackColor = true;
            // 
            // grdItems
            // 
            grdItems.AutoGenerateColumns = false;
            grdItems.BackgroundColor = SystemColors.ControlLight;
            grdItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            grdItems.DataSource = itemMasterBindingSource;
            grdItems.Location = new Point(8, 56);
            grdItems.Margin = new Padding(3, 4, 3, 4);
            grdItems.Name = "grdItems";
            grdItems.RowHeadersWidth = 51;
            grdItems.RowTemplate.Height = 25;
            grdItems.Size = new Size(1008, 555);
            grdItems.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice";
            dataGridViewTextBoxColumn4.HeaderText = "UnitPrice";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ExtPrice";
            dataGridViewTextBoxColumn5.HeaderText = "ExtPrice";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // itemMasterBindingSource
            // 
            itemMasterBindingSource.DataSource = typeof(ItemInfo);
            // 
            // btnClearlList
            // 
            btnClearlList.Location = new Point(118, 11);
            btnClearlList.Margin = new Padding(5, 4, 5, 4);
            btnClearlList.Name = "btnClearlList";
            btnClearlList.Size = new Size(101, 36);
            btnClearlList.TabIndex = 2;
            btnClearlList.Text = "Clear List";
            btnClearlList.UseVisualStyleBackColor = true;
            btnClearlList.Click += btnClearlList_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(8, 12);
            btnImport.Margin = new Padding(5, 4, 5, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(101, 36);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // frmBOM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 692);
            Controls.Add(appPartLIst);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmBOM";
            Text = "Bill of Material";
            Load += frmBOM_Load;
            appPartLIst.ResumeLayout(false);
            tbBOM.ResumeLayout(false);
            tbBOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdBom).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).EndInit();
            tabItemMaster.ResumeLayout(false);
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
        private ComboBox cmbClass;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TabPage tabItemMaster;
        private Button btnClearlList;
        private Button btnImport;
        private DataGridView grdBom;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn extPriceDataGridViewTextBoxColumn;
        private BindingSource itemInfoBindingSource;
        private DataGridView grdItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource itemMasterBindingSource;
    }
}

