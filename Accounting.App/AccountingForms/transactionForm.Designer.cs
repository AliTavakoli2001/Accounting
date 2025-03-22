using System;

namespace Accounting.App.AccountingForms
{
    partial class transactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.dgvCustomerName = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdPay = new System.Windows.Forms.RadioButton();
            this.rdRecive = new System.Windows.Forms.RadioButton();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            DTSelector = new Atf.UI.DateTimeSelector();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerName)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterBox);
            this.groupBox1.Controls.Add(this.dgvCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(6, 44);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(223, 26);
            this.filterBox.TabIndex = 2;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.AllowUserToAddRows = false;
            this.dgvCustomerName.AllowUserToDeleteRows = false;
            this.dgvCustomerName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCustomerName.Location = new System.Drawing.Point(6, 76);
            this.dgvCustomerName.Name = "dgvCustomerName";
            this.dgvCustomerName.ReadOnly = true;
            this.dgvCustomerName.RowHeadersWidth = 51;
            this.dgvCustomerName.RowTemplate.Height = 24;
            this.dgvCustomerName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCustomerName.Size = new System.Drawing.Size(223, 513);
            this.dgvCustomerName.TabIndex = 1;
            this.dgvCustomerName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerName_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(DTSelector);
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Controls.Add(this.numAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdPay);
            this.groupBox2.Controls.Add(this.rdRecive);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(251, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 595);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات تراکنش";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("IRANYekanWeb", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(335, 559);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "ذخیره";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("IRANYekanWeb", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(6, 260);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(329, 293);
            this.txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "توضیحات:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "تاریخ:";
            // 
            // DTSelector
            // 
            DTSelector.Format = Atf.UI.DateTimeSelectorFormat.Long;
            DTSelector.Location = new System.Drawing.Point(135, 206);
            DTSelector.Name = "DTSelector";
            DTSelector.Size = new System.Drawing.Size(200, 27);
            DTSelector.Style = Atf.UI.DropDownControlStyle.List;
            DTSelector.TabIndex = 9;
            DTSelector.UsePersianFormat = true;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("IRANYekanWeb", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(77, 170);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(0, 21);
            this.Amount.TabIndex = 7;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(77, 128);
            this.numAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(258, 26);
            this.numAmount.TabIndex = 6;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "مبلغ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع:";
            // 
            // rdPay
            // 
            this.rdPay.AutoSize = true;
            this.rdPay.Location = new System.Drawing.Point(193, 89);
            this.rdPay.Name = "rdPay";
            this.rdPay.Size = new System.Drawing.Size(68, 22);
            this.rdPay.TabIndex = 3;
            this.rdPay.TabStop = true;
            this.rdPay.Text = "پرداخت";
            this.rdPay.UseVisualStyleBackColor = true;
            // 
            // rdRecive
            // 
            this.rdRecive.AutoSize = true;
            this.rdRecive.Location = new System.Drawing.Point(267, 89);
            this.rdRecive.Name = "rdRecive";
            this.rdRecive.Size = new System.Drawing.Size(68, 22);
            this.rdRecive.TabIndex = 2;
            this.rdRecive.TabStop = true;
            this.rdRecive.Text = "دریافت";
            this.rdRecive.UseVisualStyleBackColor = true;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(6, 44);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(329, 26);
            this.txtCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "شخص:";
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.numAmount;
            this.rangeValidator1.ErrorMessage = "لطفا مبلغ را صحیح وارد کنید.";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "999999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtCustomer;
            this.requiredFieldValidator1.ErrorMessage = "!لطفا از منوی مقابل شخصی را انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANYekanWeb", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "transactionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.transactionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerName)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdPay;
        private System.Windows.Forms.RadioButton rdRecive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private ValidationComponents.RangeValidator rangeValidator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}