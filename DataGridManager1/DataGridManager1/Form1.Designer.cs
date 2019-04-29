namespace DataGridManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.DGCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGCustMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnCellValue = new System.Windows.Forms.Button();
            this.BtnRow = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCustomer
            // 
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGCustomerID,
            this.DGCustName,
            this.DGCustMobile});
            this.DGCustomer.Location = new System.Drawing.Point(29, 27);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.Size = new System.Drawing.Size(545, 140);
            this.DGCustomer.TabIndex = 0;
            // 
            // DGCustomerID
            // 
            this.DGCustomerID.HeaderText = "Customer ID";
            this.DGCustomerID.Name = "DGCustomerID";
            // 
            // DGCustName
            // 
            this.DGCustName.HeaderText = "Name";
            this.DGCustName.Name = "DGCustName";
            this.DGCustName.Width = 300;
            // 
            // DGCustMobile
            // 
            this.DGCustMobile.HeaderText = "Mobile";
            this.DGCustMobile.Name = "DGCustMobile";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(595, 27);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(97, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnCellValue
            // 
            this.BtnCellValue.Location = new System.Drawing.Point(595, 56);
            this.BtnCellValue.Name = "BtnCellValue";
            this.BtnCellValue.Size = new System.Drawing.Size(97, 23);
            this.BtnCellValue.TabIndex = 2;
            this.BtnCellValue.Text = "Get Cell Value";
            this.BtnCellValue.UseVisualStyleBackColor = true;
            this.BtnCellValue.Click += new System.EventHandler(this.BtnCellValue_Click);
            // 
            // BtnRow
            // 
            this.BtnRow.Location = new System.Drawing.Point(595, 86);
            this.BtnRow.Name = "BtnRow";
            this.BtnRow.Size = new System.Drawing.Size(97, 23);
            this.BtnRow.TabIndex = 3;
            this.BtnRow.Text = "Delete Row";
            this.BtnRow.UseVisualStyleBackColor = true;
            this.BtnRow.Click += new System.EventHandler(this.BtnRow_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(595, 116);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(97, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save Data";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(595, 145);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(97, 22);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "PPDReport";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDReport_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 229);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRow);
            this.Controls.Add(this.BtnCellValue);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.DGCustomer);
            this.Name = "Form1";
            this.Text = "FrnDataEntry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCustMobile;
        private System.Windows.Forms.Button BtnCellValue;
        private System.Windows.Forms.Button BtnRow;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

