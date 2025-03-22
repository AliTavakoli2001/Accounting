using Accounting.DataLayer;
using Accounting.Utility.Convert;
using Accounting.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.AccountingForms
{
    public partial class transactionForm : Form
    {
        private int customerID;
        public int accountID = 0;
        // DTSelecto باید اینجا تعریف شود (رفرنس دهی شود) و در transactionForm.Designer.cs مقدار دهی شود.
        Atf.UI.DateTimeSelector DTSelector;

        public transactionForm()
        {
            InitializeComponent();
            DTSelector.Value = DateTime.Now;
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork DB = new UnitOfWork())
            {
                dgvCustomerName.DataSource = DB.customersRepository.GetCustomerName(filterBox.Text);
            }
        }

        private void BindGrid()
        {
            dgvCustomerName.AutoGenerateColumns = false;
            using (UnitOfWork DB = new UnitOfWork())
            {
                dgvCustomerName.DataSource = DB.customersRepository.GetCustomerName();
            }
        }

        private void transactionForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            if (accountID != 0)
            {
                using (UnitOfWork DB = new UnitOfWork())
                {
                    DataLayer.Accounting accounting = DB.accountingRepository.GetByID(accountID);
                    txtCustomer.Text = DB.customersRepository.GetCustomerNameByID(accounting.CustomerID);
                    customerID = accounting.CustomerID;
                    txtDescription.Text = accounting.Description;
                    numAmount.Value = accounting.Amount;
                    Amount.Text = numAmount.Value.ToString("#,0 تومان");
                    if (accounting.Type == 1)
                        rdPay.Checked = true;
                    else
                        rdRecive.Checked = true;
                    DTSelector.Value = accounting.DateTime;
                }
                saveBtn.Text = "ویرایش";
                this.Text = "ویرایش تراکنش";
            }
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            Amount.Text = numAmount.Value.ToString("#,0 تومان");
        }

        private bool isValidFields()
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (!rdPay.Checked && !rdRecive.Checked)
                {
                    MessageBox.Show("لطفا یک نوع را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            return false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isValidFields())
            {
                try
                {
                    DataLayer.Accounting account = new DataLayer.Accounting()
                    {
                        CustomerID = customerID,
                        Type = (rdPay.Checked) ? 1 : 2,
                        Amount = (int)numAmount.Value,
                        Description = txtDescription.Text,
                        DateTime = (DateTime)DTSelector.Value,
                    };
                    using (UnitOfWork DB = new UnitOfWork())
                    {
                        if (accountID == 0)
                            DB.accountingRepository.Insert(account);
                        else
                        {
                            account.ID = accountID;
                            DB.accountingRepository.Update(account);
                        }
                        DB.Save();
                    }
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void dgvCustomerName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomerName.SelectedRows != null)
            {
                txtCustomer.Text = dgvCustomerName.CurrentRow.Cells[0].Value.ToString();
                customerID = (int)dgvCustomerName.CurrentRow.Cells[1].Value;
            }
        }
    }
}
