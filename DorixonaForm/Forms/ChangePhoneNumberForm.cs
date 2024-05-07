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
    public partial class ChangePhoneNumberForm : Form
    {
        Functions functions = new Functions();
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public ChangePhoneNumberForm(string login)
        {
            NewLogin = login;
            SmsPassword = random.Next(10000, 99999);
            InitializeComponent();
        }

        private void btChangePhoneNumber_Click(object sender, EventArgs e)
        {
            if (txNewPhoneNumber.Text.Length > 0)
            {
                if (txSmsPassword.Text == SmsPassword.ToString())
                {
                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            employe.PhoneNumber = txNewPhoneNumber.Text;
                        }
                        streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                    }
                    streamWriter.Close();
                    MessageBox.Show($"Muvaffaqqiyatli o'zgardi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Tasdiqlash kodi noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Telefon raqam kiritmadingiz", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void txSendPassword_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employeInformation in functions.employeList)
            {
                if (employeInformation.PhoneNumber == txNewPhoneNumber.Text)
                {
                    sanoq = 1;
                }
            }
            if (sanoq == 1)
            {
                MessageBox.Show("Telefon raqam oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Thread.Sleep(2000);
                MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
