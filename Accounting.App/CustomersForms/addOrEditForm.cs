using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.UnitOfWork;
using ValidationComponents;


namespace Accounting.App.CustomersForms
{
    public partial class addOrEditForm : Form
    {

        public int customerID = 0;
        public addOrEditForm()
        {
            InitializeComponent();
        }

        private void selectPicBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                    customerPicture.ImageLocation = fileDialog.FileName;
            }
        }

        private bool isValidFields()
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (Regex.IsMatch(txtPhoneNumber.Text.ToString(), @"^0\d{10}$"))
                    return true;
                else
                {
                    MessageBox.Show("لطفا شماره همراه را درست وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        private void saveChangeBtn_Click(object sender, EventArgs e)
        {
            if (isValidFields())
            {
                try
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(customerPicture.ImageLocation);
                    string path = Application.StartupPath + "/images/";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    customerPicture.Image.Save(path + imageName);
                    Customers customers = new Customers()
                    {
                        FullName = txtFullName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Address = txtAddress.Text,
                        CustomersImage = imageName
                    };

                    using (UnitOfWork DB = new UnitOfWork())
                    {
                        if (customerID == 0)
                            DB.customersRepository.InsertCustomers(customers);
                        else
                        {
                            customers.CustomerID = customerID;
                            DB.customersRepository.UpdateCustomers(customers);
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

        private void addOrEditForm_Load(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                this.Text = "ویرایش شخص";
                saveChangeBtn.Text = "ثبت تغییرات";
                using (UnitOfWork DB = new UnitOfWork())
                {
                    Customers customer = DB.customersRepository.GetCustomerByID(customerID);
                    txtFullName.Text = customer.FullName;
                    txtEmail.Text = customer.Email;
                    txtPhoneNumber.Text = customer.PhoneNumber;
                    txtAddress.Text = customer.Address;
                    customerPicture.ImageLocation = Application.StartupPath + "/images/" + customer.CustomersImage;
                }
            }
        }
    }
}
