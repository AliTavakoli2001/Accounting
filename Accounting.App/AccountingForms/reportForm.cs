using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Utility.Convert;
using Accounting.Utility.Report;
using Accounting.DataLayer.UnitOfWork;
using Accounting.ViewModel;
using Accounting.DataLayer;
using ValidationComponents;
using System.Text.RegularExpressions;


namespace Accounting.App.AccountingForms
{
    public partial class reportForm : Form
    {
        public bool isReciveReport;
        public reportForm()
        {
            InitializeComponent();
        }

        private bool isValidFormDate()
        {
            if (msFromDate.Text == "    /  /" || Regex.IsMatch(msFromDate.Text, @"^\d{4}/\d{2}/\d{2}$"))
                if (msToDate.Text == "    /  /" || Regex.IsMatch(msToDate.Text, @"^\d{4}/\d{2}/\d{2}$"))
                    return true;
            MessageBox.Show("لطفا تاریخ را به شکل درست وارد کنید", "خطا");
            return false;
        }

        private void Filter()
        {

            using (UnitOfWork DB = new UnitOfWork())
            {
                List<DataLayer.Accounting> accountsList = new List<DataLayer.Accounting>();
                DateTime? startDate;
                DateTime? endDate;


                if ((int)cbCustomer.SelectedValue != 0)
                    accountsList.AddRange(DB.accountingRepository.Get(transaction => transaction.Type == (isReciveReport ? 2 : 1) &&
                    transaction.CustomerID == (int)cbCustomer.SelectedValue));
                else
                    accountsList.AddRange(DB.accountingRepository.Get(transaction => transaction.Type == (isReciveReport ? 2 : 1)));

                if (isValidFormDate())
                {

                    if (msFromDate.Text != "    /  /")
                    {
                        try
                        {
                            startDate = Convert.ToDateTime(msFromDate.Text);
                            startDate = startDate.Value.toMilady();
                            accountsList = accountsList.Where(transaction => transaction.DateTime >= startDate.Value).ToList();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("لطفا تاریخ شروع را درست وارد کنید", "خطا");
                        }
                    }
                    if (msToDate.Text != "    /  /")
                    {
                        try
                        {
                            endDate = Convert.ToDateTime(msToDate.Text);
                            endDate = endDate.Value.toMilady();
                            accountsList = accountsList.Where(transaction => transaction.DateTime <= endDate.Value).ToList();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("لطفا تاریخ پایان را درست وارد کنید", "خطا");
                        }
                    }

                    dgvReport.Rows.Clear();
                    foreach (var accounting in accountsList)
                    {
                        string customerName = DB.customersRepository.GetCustomerNameByID(accounting.CustomerID);
                        dgvReport.Rows.Add(accounting.ID, customerName, accounting.Amount.ToString("#,0"), accounting.DateTime.toShamsi(), accounting.Description);
                    }
                }
            }
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            if (isReciveReport)
                this.Text = "گزارش دریافتی";
            else
                this.Text = "گزارش پرداختی";


            List<CustomerName_ID> customerName_IDs = new List<CustomerName_ID>();
            customerName_IDs.Add(new CustomerName_ID()
            {
                CustomerID = 0,
                FullName = "همه"
            });

            using (UnitOfWork DB = new UnitOfWork())
            {
                customerName_IDs.AddRange(DB.customersRepository.GetCustomerName());
            }
            cbCustomer.DataSource = customerName_IDs;
            cbCustomer.DisplayMember = "FullName";
            cbCustomer.ValueMember = "CustomerID";
            Filter();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            msFromDate.Text = "    /  /";
            msToDate.Text = "    /  /";
            cbCustomer.SelectedValue = 0;
            Filter();
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                using (UnitOfWork DB = new UnitOfWork())
                {
                    string message = $"آیا از حذف صورت حساب {dgvReport.CurrentRow.Cells[1].Value.ToString()} مطمئن هستید؟";
                    if (MessageBox.Show(message, "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DB.accountingRepository.Delete((int)dgvReport.CurrentRow.Cells[0].Value);
                        DB.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                transactionForm transaction_Form = new transactionForm();
                transaction_Form.accountID = (int)dgvReport.CurrentRow.Cells[0].Value;
                if (transaction_Form.ShowDialog() == DialogResult.OK)
                    Filter();
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = "گزارش اطلاعات";
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.StartPosition = FormStartPosition.CenterParent;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print print = new Print(e, dgvReport);
            print.titleText = (isReciveReport) ? "اطلاعات تراکنش های دریافتی" : "اطلاعات تراکنش های پرداختی";
            print.PrintConfiguration();
        }
    }
}
