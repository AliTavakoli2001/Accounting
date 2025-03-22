using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.UnitOfWork;
using Accounting.App.CustomersForms;
using System.IO;
using System.Drawing.Printing;
using Accounting.Utility.Report;

namespace Accounting.App
{
    public partial class customersForm : Form
    {
        public customersForm()
        {
            InitializeComponent();
        }

        private void customersForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork DB = new UnitOfWork())
            {
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = DB.customersRepository.GetAllCustomers();
            }
            searchBox.Text = "";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork DB = new UnitOfWork())
            {
                dgvCustomer.DataSource = DB.customersRepository.GetCustomersByFilter(searchBox.Text);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            using (addOrEditForm addOrEdit_Form = new addOrEditForm())
            {
                if (addOrEdit_Form.ShowDialog() == DialogResult.OK)
                {
                    addOrEdit_Form.Close();
                    BindGrid();
                }
                else
                    MessageBox.Show("عملیات با خطا مواجه شد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows != null)
            {
                using (UnitOfWork DB = new UnitOfWork())
                {
                    string fullName = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {fullName} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerID = (int)dgvCustomer.CurrentRow.Cells[0].Value;
                        DB.customersRepository.DeleteCustomers(customerID);
                        DB.Save();
                        string FilePath = Application.StartupPath + "/images/" + dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                        if (File.Exists(FilePath))
                            File.Delete(FilePath);
                        BindGrid();
                    }
                }
            }
            else
                MessageBox.Show("لطفا ابتدا شخصی را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void editCustomerbtn_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                using (addOrEditForm addOrEdit_Form = new addOrEditForm())
                {
                    addOrEdit_Form.customerID = (int)dgvCustomer.CurrentRow.Cells[0].Value;
                    if (addOrEdit_Form.ShowDialog() == DialogResult.OK)
                    {
                        addOrEdit_Form.Close();
                        BindGrid();
                    }
                    else
                        MessageBox.Show("عملیات با خطا مواجه شد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("لطفا ابتدا شخصی را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            customerPrint.DocumentName = "گزارش اطلاعات";
            customerPrintDialog.Document = customerPrint;
            customerPrintDialog.PrintPreviewControl.Zoom = 1;
            customerPrintDialog.StartPosition = FormStartPosition.CenterParent;
            customerPrintDialog.WindowState = FormWindowState.Maximized;
            customerPrintDialog.ShowDialog();
        }

        private void customerPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print print = new Print(e, dgvCustomer);
            print.titleText = "فرم اطلاعات اشخاص";
            print.PrintConfiguration();
        }
    }
}
