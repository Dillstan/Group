
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
            btnClearlList = new Button();
            btnImport = new Button();
            grdBom = new DataGridView();
            itemInfoBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            itemMasterBindingSource = new BindingSource(components);
            appPartLIst.SuspendLayout();
            tbBOM.SuspendLayout();
            tabItemMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdBom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tbBOM.Controls.Add(cmbClass);
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
            // txtQuantity
            // 
            txtQuantity.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Quantity", true));
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
            cmbPartNo.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Name", true));
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
            // cmbClass
            // 
            cmbClass.DataBindings.Add(new Binding("Text", itemInfoBindingSource, "Description", true));
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(103, 53);
            cmbClass.Margin = new Padding(4, 3, 4, 3);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(140, 23);
            cmbClass.TabIndex = 5;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(293, 8);
            btnPrint.Margin = new Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(88, 27);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
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
            tabItemMaster.Controls.Add(dataGridView1);
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
            // grdBom
            // 
            grdBom.AutoGenerateColumns = false;
            grdBom.BackgroundColor = SystemColors.ControlLight;
            grdBom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBom.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, extPriceDataGridViewTextBoxColumn });
            grdBom.DataSource = itemInfoBindingSource;
            grdBom.Location = new Point(8, 173);
            grdBom.Name = "grdBom";
            grdBom.RowTemplate.Height = 25;
            grdBom.Size = new Size(882, 285);
            grdBom.TabIndex = 11;
            grdBom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // itemInfoBindingSource
            // 
            itemInfoBindingSource.DataSource = typeof(MaterialList.ItemInfo);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // extPriceDataGridViewTextBoxColumn
            // 
            extPriceDataGridViewTextBoxColumn.DataPropertyName = "ExtPrice";
            extPriceDataGridViewTextBoxColumn.HeaderText = "ExtPrice";
            extPriceDataGridViewTextBoxColumn.Name = "extPriceDataGridViewTextBoxColumn";
            extPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.DataSource = itemMasterBindingSource;
            dataGridView1.Location = new Point(7, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 416);
            dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice";
            dataGridViewTextBoxColumn4.HeaderText = "UnitPrice";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ExtPrice";
            dataGridViewTextBoxColumn5.HeaderText = "ExtPrice";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // itemMasterBindingSource
            // 
            itemMasterBindingSource.DataSource = typeof(MaterialList.ItemInfo);
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
            tabItemMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdBom).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource itemMasterBindingSource;
    }
}

