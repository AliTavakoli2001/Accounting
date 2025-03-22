namespace Accounting.App
{
    partial class customersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customersForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.editCustomerbtn = new System.Windows.Forms.ToolStripButton();
            this.deleteCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPrintDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.customerPrint = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerBtn,
            this.editCustomerbtn,
            this.deleteCustomerBtn,
            this.refreshBtn,
            this.btnPrint,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "افزودن شخص";
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.newCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(91, 68);
            this.newCustomerBtn.Text = "شخص جدید";
            this.newCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // editCustomerbtn
            // 
            this.editCustomerbtn.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.editCustomerbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editCustomerbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCustomerbtn.Name = "editCustomerbtn";
            this.editCustomerbtn.Size = new System.Drawing.Size(104, 68);
            this.editCustomerbtn.Text = "ویرایش شخص";
            this.editCustomerbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editCustomerbtn.Click += new System.EventHandler(this.editCustomerbtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.deleteCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(91, 68);
            this.deleteCustomerBtn.Text = "حذف شخص";
            this.deleteCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.refreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(72, 68);
            this.refreshBtn.Text = "بروزرسانی";
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Accounting.App.Properties.Resources._1371476193_printers___Faxes;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 68);
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 68);
            this.toolStripLabel1.Text = "فیلتر:";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(140, 27);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 71);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.ShowCellErrors = false;
            this.dgvCustomer.Size = new System.Drawing.Size(582, 482);
            this.dgvCustomer.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CustomerID";
            this.Column4.HeaderText = "شناسه";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام و نام خانوادگی";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PhoneNumber";
            this.Column2.HeaderText = "شماره همراه";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "ایمیل";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CustomersImage";
            this.Column5.HeaderText = "تصویر";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // customerPrintDialog
            // 
            this.customerPrintDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.customerPrintDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.customerPrintDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.customerPrintDialog.Document = this.customerPrint;
            this.customerPrintDialog.Enabled = true;
            this.customerPrintDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("customerPrintDialog.Icon")));
            this.customerPrintDialog.Name = "customerPrintDialog";
            this.customerPrintDialog.Visible = false;
            // 
            // customerPrint
            // 
            this.customerPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.customerPrint_PrintPage);
            // 
            // customersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("IRANSansWeb", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طرف حساب";
            this.Load += new System.EventHandler(this.customersForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newCustomerBtn;
        private System.Windows.Forms.ToolStripButton editCustomerbtn;
        private System.Windows.Forms.ToolStripButton deleteCustomerBtn;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.PrintPreviewDialog customerPrintDialog;
        private System.Drawing.Printing.PrintDocument customerPrint;
    }
}