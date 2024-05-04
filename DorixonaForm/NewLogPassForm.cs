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

namespace DorixonaForm
{
    public partial class NewLogPassForm : Form
    {
        Functions functions = new Functions();
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public NewLogPassForm()
        {
            InitializeComponent();
            SmsPassword = random.Next(10000, 99999);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }
        private void txConfirmation_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employeInformation in functions.employeList)
            {
                if (employeInformation.PhoneNumber == txPhoneNumber.Text)
                {
                    sanoq = 1;
                    Thread.Sleep(1000);
                    MessageBox.Show($"Ushbu kodni hech kimga yubormang: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Ma'lumotlar topilmadi!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNewLogPass_Click(object sender, EventArgs e)
        {
            if (txPhoneNumber.Text.Length > 0)
            {
                if (txSmsPassword.Text == SmsPassword.ToString())
                {
                    int sanoq = 0;
                    foreach (Employe employe in functions.employeList)
                    {
                        if (employe.Login == txNewLogin.Text)
                        {
                            sanoq = 1;
                        }
                    }
                    if (txNewLogin.Text.Length > 0 || txNewPassword.Text.Length > 0)
                    {
                        if (sanoq == 0)
                        {
                            StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                            int i = 1;
                            foreach (Employe employe in functions.employeList)
                            {
                                if (employe.PhoneNumber == txPhoneNumber.Text)
                                {
                                    sanoq = 2;
                                    employe.Login = txNewLogin.Text;
                                    employe.Password = txNewPassword.Text;
                                }
                                streamWriter.WriteLine(i++.ToString() + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                            }
                            streamWriter.Close();
                            if (sanoq == 2)
                            {
                                MessageBox.Show($"Login va parol o'zgartirildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                LoginForm loginForm = new LoginForm();
                                loginForm.StartPosition = FormStartPosition.CenterScreen;
                                loginForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Telefon raqamingiz noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bunday login oldindan mavjud, Iltimos boshqa kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bo'sh qiymat berish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tasdiqlash kodi noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Telefon raqamingizni kiritmadingiz", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
