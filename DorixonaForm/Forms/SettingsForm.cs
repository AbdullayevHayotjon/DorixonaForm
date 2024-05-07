using DorixonaForm.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DorixonaForm.Forms
{
    public partial class SettingsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public SettingsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }
        private void btChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(NewLogin);
            changePasswordForm.StartPosition = FormStartPosition.CenterScreen;
            changePasswordForm.Show();
        }

        private void btChangeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(NewLogin);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btChangePhoneNumber_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePhoneNumberForm changePhoneNumberForm = new ChangePhoneNumberForm(NewLogin);
            changePhoneNumberForm.StartPosition = FormStartPosition.CenterScreen;
            changePhoneNumberForm.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.Login == NewLogin)
                {
                    if (employe.EmployeType == EmployeType.Manager.ToString())
                    {
                        sanoq = 1;
                    }
                    else
                    {
                        sanoq = 2;
                    }
                    break;
                }
            }
            if (sanoq == 1)
            {
                this.Hide();
                ManagerForm managerForm = new ManagerForm(NewLogin);
                managerForm.StartPosition = FormStartPosition.CenterScreen;
                managerForm.Show();
            }
            else
            {
                this.Hide();
                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                salesmanForm.Show();
            }
        }
    }
}
