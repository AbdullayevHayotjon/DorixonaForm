using DorixonaForm.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm.Forms
{
    public partial class ChangePasswordForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ChangePasswordForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void btSaveNewPassword_Click(object sender, EventArgs e)
        {
            if (txOldPassword.Text.Length > 0 && txNewPassword.Text.Length > 0 && txNewPassword2.Text.Length > 0)
            {
                int sanoq = 0;
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.Login == NewLogin)
                    {
                        sanoq = 3;
                        if (employe.Password == txOldPassword.Text)
                        {
                            sanoq = 1;
                            if (txNewPassword.Text == txNewPassword2.Text)
                            {
                                sanoq = 2;
                                employe.Password = txNewPassword.Text;
                            }
                        }
                    }
                }
                if (sanoq == 2)
                {
                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                    foreach (Employe employe in functions.employeList)
                    {
                        streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                    }
                    streamWriter.Close();
                    MessageBox.Show($"Muvaffaqqiyatli o'zgartirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int sanoq1 = 0;
                    foreach (Employe employe in functions.employeList)
                    {
                        if (employe.Login == NewLogin)
                        {
                            if (employe.EmployeType == EmployeType.Manager.ToString())
                            {
                                sanoq1 = 1;
                            }
                            else
                            {
                                sanoq1 = 2;
                            }
                            break;
                        }
                    }
                    if (sanoq1 == 1)
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
                else if (sanoq == 1)
                {
                    MessageBox.Show("Tasdiqlash paroli xato", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Oldingi kodingiz xato", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bo'sh qiymat kiritish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
