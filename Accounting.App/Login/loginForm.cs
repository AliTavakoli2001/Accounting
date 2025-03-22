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

namespace Accounting.App.Login
{
    public partial class loginForm : Form
    {
        public bool changePassword { get; set; } = false;

        public loginForm()
        {
            InitializeComponent();
        }

        private bool isFromValid()
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                return true;
            }
            return false;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (changePassword)
            {
                this.Text = "تغییر نام کاربری و رمز عبور";
                btnSubmit.Text = "ذخیره";
                using (UnitOfWork DB = new UnitOfWork())
                {
                    DataLayer.Login login = DB.loginRepository.Get().First();
                    txtUsername.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isFromValid())
            {
                bool result;
                DataLayer.Login login = new DataLayer.Login()
                {
                    LoginID = 1,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                };

                using (UnitOfWork DB = new UnitOfWork())
                {
                    if (changePassword)
                    {
                        DB.loginRepository.Update(login);
                        DB.Save();
                        MessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر یافت", "پیام", MessageBoxButtons.OK);
                        DialogResult = DialogResult.OK;
                        Application.Restart();
                    }
                    else
                    {
                        result = DB.loginRepository.Get(user => user.UserName == txtUsername.Text &&
                        user.Password == txtPassword.Text).Any();

                        if (result)
                            DialogResult = DialogResult.OK;
                        else
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
