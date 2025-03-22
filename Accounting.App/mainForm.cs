using Accounting.App.AccountingForms;
using Accounting.Utility.Convert;
using Accounting.Business;
using Gremlin.Net.Process.Traversal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Business.Accounting;
using Accounting.ViewModel.Accounting;
using Accounting.App.Login;

namespace Accounting.App
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void BindReport()
        {
            ReportForm monthReport = Report.Create();

            lblRecive.Text = monthReport.recive.ToString("#,0 تومان");
            lblPay.Text = monthReport.pay.ToString("#,0 تومان");
            lblBalance.Text = monthReport.balance.ToString("#,0 تومان");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            if (login.ShowDialog() == DialogResult.OK)
                this.Show();
            else
                Application.Exit();

                txtDate.Text = DateTime.Now.toShamsi();
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            BindReport();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            customersForm customers_Form = new customersForm();
            if (customers_Form.ShowDialog() == DialogResult.Cancel)
                BindReport();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            transactionForm transaction_Form = new transactionForm();
            if (transaction_Form.ShowDialog() == DialogResult.OK)
                BindReport();
        }
        private void btnReciveReport_Click(object sender, EventArgs e)
        {
            reportForm report_Form = new reportForm();
            report_Form.isReciveReport = true;
            if (report_Form.ShowDialog() == DialogResult.Cancel)
                BindReport();
        }

        private void btnPayReport_Click(object sender, EventArgs e)
        {
            reportForm report_Form = new reportForm();
            report_Form.isReciveReport = false;
            if (report_Form.ShowDialog() == DialogResult.Cancel)
                BindReport();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.changePassword = true;
            login.ShowDialog();
        }
    }
}
