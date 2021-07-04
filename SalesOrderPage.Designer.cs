
namespace SalesOrderApp
{
    partial class SalesOrderPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotIncl = new System.Windows.Forms.TextBox();
            this.txtTotTax = new System.Windows.Forms.TextBox();
            this.txtTotExcl = new System.Windows.Forms.TextBox();
            this.lblTotIncl = new System.Windows.Forms.Label();
            this.lblTotTax = new System.Windows.Forms.Label();
            this.lblTotExcl = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgcmbItemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcmbDescription = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgtxtNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtExcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtInclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.cmbCusName = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblReferenceNo = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Order";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(11, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotIncl);
            this.panel2.Controls.Add(this.txtTotTax);
            this.panel2.Controls.Add(this.txtTotExcl);
            this.panel2.Controls.Add(this.lblTotIncl);
            this.panel2.Controls.Add(this.lblTotTax);
            this.panel2.Controls.Add(this.lblTotExcl);
            this.panel2.Controls.Add(this.dgvItems);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.txtReferenceNo);
            this.panel2.Controls.Add(this.txtInvoiceDate);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.txtPostCode);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.txtSuburb);
            this.panel2.Controls.Add(this.txtAdd3);
            this.panel2.Controls.Add(this.txtAdd2);
            this.panel2.Controls.Add(this.txtAdd1);
            this.panel2.Controls.Add(this.cmbCusName);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.lblReferenceNo);
            this.panel2.Controls.Add(this.lblInvoiceDate);
            this.panel2.Controls.Add(this.lblInvoiceNo);
            this.panel2.Controls.Add(this.lblPostCode);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblSuburb);
            this.panel2.Controls.Add(this.lblAdd3);
            this.panel2.Controls.Add(this.lblAdd2);
            this.panel2.Controls.Add(this.lblAdd1);
            this.panel2.Controls.Add(this.lblCusName);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 561);
            this.panel2.TabIndex = 2;
            // 
            // txtTotIncl
            // 
            this.txtTotIncl.Location = new System.Drawing.Point(620, 512);
            this.txtTotIncl.Name = "txtTotIncl";
            this.txtTotIncl.ReadOnly = true;
            this.txtTotIncl.Size = new System.Drawing.Size(335, 20);
            this.txtTotIncl.TabIndex = 28;
            // 
            // txtTotTax
            // 
            this.txtTotTax.Location = new System.Drawing.Point(620, 486);
            this.txtTotTax.Name = "txtTotTax";
            this.txtTotTax.ReadOnly = true;
            this.txtTotTax.Size = new System.Drawing.Size(335, 20);
            this.txtTotTax.TabIndex = 27;
            // 
            // txtTotExcl
            // 
            this.txtTotExcl.Location = new System.Drawing.Point(620, 460);
            this.txtTotExcl.Name = "txtTotExcl";
            this.txtTotExcl.ReadOnly = true;
            this.txtTotExcl.Size = new System.Drawing.Size(335, 20);
            this.txtTotExcl.TabIndex = 26;
            // 
            // lblTotIncl
            // 
            this.lblTotIncl.AutoSize = true;
            this.lblTotIncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotIncl.Location = new System.Drawing.Point(516, 516);
            this.lblTotIncl.Name = "lblTotIncl";
            this.lblTotIncl.Size = new System.Drawing.Size(62, 16);
            this.lblTotIncl.TabIndex = 25;
            this.lblTotIncl.Text = "Total Incl";
            // 
            // lblTotTax
            // 
            this.lblTotTax.AutoSize = true;
            this.lblTotTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotTax.Location = new System.Drawing.Point(516, 490);
            this.lblTotTax.Name = "lblTotTax";
            this.lblTotTax.Size = new System.Drawing.Size(65, 16);
            this.lblTotTax.TabIndex = 24;
            this.lblTotTax.Text = "Total Tax";
            // 
            // lblTotExcl
            // 
            this.lblTotExcl.AutoSize = true;
            this.lblTotExcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotExcl.Location = new System.Drawing.Point(516, 464);
            this.lblTotExcl.Name = "lblTotExcl";
            this.lblTotExcl.Size = new System.Drawing.Size(67, 16);
            this.lblTotExcl.TabIndex = 23;
            this.lblTotExcl.Text = "Total Excl";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcmbItemCode,
            this.dgcmbDescription,
            this.dgtxtNote,
            this.dgtxtQty,
            this.dgtxtPrice,
            this.dgtxtTax,
            this.dgtxtExcl,
            this.dgtxtTaxAmount,
            this.dgtxtInclAmount});
            this.dgvItems.Location = new System.Drawing.Point(11, 251);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(944, 181);
            this.dgvItems.TabIndex = 22;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItems_CellFormatting);
            // 
            // dgcmbItemCode
            // 
            this.dgcmbItemCode.HeaderText = "Item Code";
            this.dgcmbItemCode.Name = "dgcmbItemCode";
            // 
            // dgcmbDescription
            // 
            this.dgcmbDescription.HeaderText = "Description";
            this.dgcmbDescription.Name = "dgcmbDescription";
            // 
            // dgtxtNote
            // 
            this.dgtxtNote.HeaderText = "Note";
            this.dgtxtNote.Name = "dgtxtNote";
            // 
            // dgtxtQty
            // 
            this.dgtxtQty.HeaderText = "Quantity";
            this.dgtxtQty.Name = "dgtxtQty";
            // 
            // dgtxtPrice
            // 
            this.dgtxtPrice.HeaderText = "Price";
            this.dgtxtPrice.Name = "dgtxtPrice";
            // 
            // dgtxtTax
            // 
            this.dgtxtTax.HeaderText = "Tax";
            this.dgtxtTax.Name = "dgtxtTax";
            // 
            // dgtxtExcl
            // 
            this.dgtxtExcl.HeaderText = "Excl Amount";
            this.dgtxtExcl.Name = "dgtxtExcl";
            this.dgtxtExcl.ReadOnly = true;
            // 
            // dgtxtTaxAmount
            // 
            this.dgtxtTaxAmount.HeaderText = "Tax Amount";
            this.dgtxtTaxAmount.Name = "dgtxtTaxAmount";
            this.dgtxtTaxAmount.ReadOnly = true;
            // 
            // dgtxtInclAmount
            // 
            this.dgtxtInclAmount.HeaderText = "Incl Amount";
            this.dgtxtInclAmount.Name = "dgtxtInclAmount";
            this.dgtxtInclAmount.ReadOnly = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(620, 113);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(335, 106);
            this.txtNote.TabIndex = 21;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(620, 84);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(335, 20);
            this.txtReferenceNo.TabIndex = 20;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(620, 53);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(335, 20);
            this.txtInvoiceDate.TabIndex = 19;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(620, 22);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(335, 20);
            this.txtInvoiceNo.TabIndex = 18;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(131, 201);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.ReadOnly = true;
            this.txtPostCode.Size = new System.Drawing.Size(276, 20);
            this.txtPostCode.TabIndex = 17;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(131, 171);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(276, 20);
            this.txtState.TabIndex = 16;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(131, 141);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(276, 20);
            this.txtSuburb.TabIndex = 15;
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(131, 111);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.ReadOnly = true;
            this.txtAdd3.Size = new System.Drawing.Size(276, 20);
            this.txtAdd3.TabIndex = 14;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(131, 81);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.ReadOnly = true;
            this.txtAdd2.Size = new System.Drawing.Size(276, 20);
            this.txtAdd2.TabIndex = 13;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(131, 51);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.ReadOnly = true;
            this.txtAdd1.Size = new System.Drawing.Size(276, 20);
            this.txtAdd1.TabIndex = 12;
            // 
            // cmbCusName
            // 
            this.cmbCusName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCusName.FormattingEnabled = true;
            this.cmbCusName.Location = new System.Drawing.Point(131, 20);
            this.cmbCusName.Name = "cmbCusName";
            this.cmbCusName.Size = new System.Drawing.Size(276, 21);
            this.cmbCusName.TabIndex = 11;
            this.cmbCusName.SelectedValueChanged += new System.EventHandler(this.cmbCusName_SelectedValueChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(516, 117);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 16);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "Note";
            // 
            // lblReferenceNo
            // 
            this.lblReferenceNo.AutoSize = true;
            this.lblReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenceNo.Location = new System.Drawing.Point(516, 88);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Size = new System.Drawing.Size(95, 16);
            this.lblReferenceNo.TabIndex = 9;
            this.lblReferenceNo.Text = "Reference No.";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(516, 57);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(83, 16);
            this.lblInvoiceDate.TabIndex = 8;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(516, 26);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(75, 16);
            this.lblInvoiceNo.TabIndex = 7;
            this.lblInvoiceNo.Text = "Invoice No.";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(21, 204);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(71, 16);
            this.lblPostCode.TabIndex = 6;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(21, 174);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 16);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(21, 144);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(51, 16);
            this.lblSuburb.TabIndex = 4;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAdd3
            // 
            this.lblAdd3.AutoSize = true;
            this.lblAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd3.Location = new System.Drawing.Point(21, 114);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(69, 16);
            this.lblAdd3.TabIndex = 3;
            this.lblAdd3.Text = "Address 3";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.Location = new System.Drawing.Point(21, 84);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(69, 16);
            this.lblAdd2.TabIndex = 2;
            this.lblAdd2.Text = "Address 2";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(21, 54);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(69, 16);
            this.lblAdd1.TabIndex = 1;
            this.lblAdd1.Text = "Address 1";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(21, 24);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(105, 16);
            this.lblCusName.TabIndex = 0;
            this.lblCusName.Text = "Customer Name";
            // 
            // SalesOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SalesOrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.ComboBox cmbCusName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblReferenceNo;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtTotIncl;
        private System.Windows.Forms.TextBox txtTotTax;
        private System.Windows.Forms.TextBox txtTotExcl;
        private System.Windows.Forms.Label lblTotIncl;
        private System.Windows.Forms.Label lblTotTax;
        private System.Windows.Forms.Label lblTotExcl;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcmbItemCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcmbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtExcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtInclAmount;
        private System.Windows.Forms.Button btnSave;
    }
}

