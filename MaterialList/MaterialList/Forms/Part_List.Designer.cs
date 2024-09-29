
namespace BOM
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
            this.appPartLIst = new System.Windows.Forms.TabControl();
            this.tbBOM = new System.Windows.Forms.TabPage();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.cmbPartNo = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabItemMaster = new System.Windows.Forms.TabPage();
            this.btnClearlList = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.appPartLIst.SuspendLayout();
            this.tbBOM.SuspendLayout();
            this.tabItemMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // appPartLIst
            // 
            this.appPartLIst.Controls.Add(this.tbBOM);
            this.appPartLIst.Controls.Add(this.tabItemMaster);
            this.appPartLIst.Location = new System.Drawing.Point(12, 12);
            this.appPartLIst.Name = "appPartLIst";
            this.appPartLIst.SelectedIndex = 0;
            this.appPartLIst.Size = new System.Drawing.Size(776, 426);
            this.appPartLIst.TabIndex = 0;
            // 
            // tbBOM
            // 
            this.tbBOM.Controls.Add(this.txtQuantity);
            this.tbBOM.Controls.Add(this.lblQuantity);
            this.tbBOM.Controls.Add(this.lblPartNo);
            this.tbBOM.Controls.Add(this.cmbPartNo);
            this.tbBOM.Controls.Add(this.lblClass);
            this.tbBOM.Controls.Add(this.cmbClass);
            this.tbBOM.Controls.Add(this.btnPrint);
            this.tbBOM.Controls.Add(this.btnSave);
            this.tbBOM.Controls.Add(this.btnDelete);
            this.tbBOM.Controls.Add(this.btnEdit);
            this.tbBOM.Controls.Add(this.btnAdd);
            this.tbBOM.Location = new System.Drawing.Point(4, 22);
            this.tbBOM.Name = "tbBOM";
            this.tbBOM.Padding = new System.Windows.Forms.Padding(3);
            this.tbBOM.Size = new System.Drawing.Size(768, 400);
            this.tbBOM.TabIndex = 0;
            this.tbBOM.Text = "BOM";
            this.tbBOM.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(88, 100);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(36, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.Location = new System.Drawing.Point(16, 81);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(66, 13);
            this.lblPartNo.TabIndex = 8;
            this.lblPartNo.Text = "Part Number";
            // 
            // cmbPartNo
            // 
            this.cmbPartNo.FormattingEnabled = true;
            this.cmbPartNo.Location = new System.Drawing.Point(88, 73);
            this.cmbPartNo.Name = "cmbPartNo";
            this.cmbPartNo.Size = new System.Drawing.Size(205, 21);
            this.cmbPartNo.TabIndex = 7;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(28, 54);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(54, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Part Class";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(88, 46);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(331, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tabItemMaster
            // 
            this.tabItemMaster.Controls.Add(this.btnClearlList);
            this.tabItemMaster.Controls.Add(this.btnImport);
            this.tabItemMaster.Location = new System.Drawing.Point(4, 22);
            this.tabItemMaster.Name = "tabItemMaster";
            this.tabItemMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemMaster.Size = new System.Drawing.Size(768, 400);
            this.tabItemMaster.TabIndex = 1;
            this.tabItemMaster.Text = "Item Master";
            this.tabItemMaster.UseVisualStyleBackColor = true;
            // 
            // btnClearlList
            // 
            this.btnClearlList.Location = new System.Drawing.Point(88, 7);
            this.btnClearlList.Name = "btnClearlList";
            this.btnClearlList.Size = new System.Drawing.Size(75, 23);
            this.btnClearlList.TabIndex = 2;
            this.btnClearlList.Text = "Clear List";
            this.btnClearlList.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // frmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appPartLIst);
            this.Name = "frmBOM";
            this.Text = "Bill of Material";
            this.appPartLIst.ResumeLayout(false);
            this.tbBOM.ResumeLayout(false);
            this.tbBOM.PerformLayout();
            this.tabItemMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl appPartLIst;
        private System.Windows.Forms.TabPage tbBOM;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.ComboBox cmbPartNo;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabItemMaster;
        private System.Windows.Forms.Button btnClearlList;
        private System.Windows.Forms.Button btnImport;
    }
}

