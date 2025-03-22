namespace Accounting.App
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.customersBtn = new System.Windows.Forms.ToolStripButton();
            this.transactionBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnPayReport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ddSeting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.txtDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersBtn,
            this.transactionBtn,
            this.toolStripButton1,
            this.btnPayReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // customersBtn
            // 
            this.customersBtn.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.customersBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(86, 68);
            this.customersBtn.Text = "طرف حساب";
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.transactionBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(94, 68);
            this.transactionBtn.Text = "تراکنش جدید";
            this.transactionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 68);
            this.toolStripButton1.Text = "گزارش دریافتی";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.btnReciveReport_Click);
            // 
            // btnPayReport
            // 
            this.btnPayReport.Image = global::Accounting.App.Properties.Resources.list2;
            this.btnPayReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayReport.Name = "btnPayReport";
            this.btnPayReport.Size = new System.Drawing.Size(104, 68);
            this.btnPayReport.Text = "گزارش پرداختی";
            this.btnPayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayReport.ToolTipText = "گزارش پرداختی";
            this.btnPayReport.Click += new System.EventHandler(this.btnPayReport_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddSeting});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(882, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ddSeting
            // 
            this.ddSeting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddSeting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePass});
            this.ddSeting.Image = ((System.Drawing.Image)(resources.GetObject("ddSeting.Image")));
            this.ddSeting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddSeting.Name = "ddSeting";
            this.ddSeting.Size = new System.Drawing.Size(75, 28);
            this.ddSeting.Text = "تنظیمات";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(224, 28);
            this.btnChangePass.Text = "تغییر رمز عبور";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDate,
            this.txtTime});
            this.statusStrip2.Location = new System.Drawing.Point(0, 623);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(882, 30);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // txtDate
            // 
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(41, 24);
            this.txtDate.Text = "Date";
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(44, 24);
            this.txtTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.accounting_logo_template_free_png;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("IRANSansWeb Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "برنامه حسابداری شخصی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("IRANSansWeb Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "- با قابلیت های ویژه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("IRANSansWeb Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "برای استفاده از منوی بالا اقدام کنید.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(518, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش تراکنش های این ماه";
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(143, 105);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(121, 23);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(129, 68);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(135, 23);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(129, 33);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(135, 23);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(253, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "مجموع:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(253, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "پرداختی:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(253, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "دریافتی:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("IRANSansWeb Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton customersBtn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton transactionBtn;
        private System.Windows.Forms.ToolStripButton btnPayReport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel txtDate;
        private System.Windows.Forms.ToolStripStatusLabel txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripDropDownButton ddSeting;
        private System.Windows.Forms.ToolStripMenuItem btnChangePass;
    }
}

