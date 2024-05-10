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
        public string NewLogin { get; set; }
        public NewLogPassForm(string login)
        {
            NewLogin = login;
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
                    Thread.Sleep(2000);
                    MessageBox.Show($"Ushbu kodni hech kimga yubormang: {SmsPassword}\nSizning loginingiz: {employeInformation.Login}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txPhoneNumber.ReadOnly = true;
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Ma'lumotlar topilmadi!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNewLogPass_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txPhoneNumber.Text) && txPhoneNumber.Text.Length == 9)
            {
                if (txSmsPassword.Text == SmsPassword.ToString())
                {
                    if (txNewPassword.Text.Length >= 4)
                    {
                        if (functions.CheckProbel(txNewPassword.Text))
                        {
                            int sanoq = 0;
                            StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                            int i = 1;
                            foreach (Employe employe in functions.employeList)
                            {
                                if (employe.PhoneNumber == txPhoneNumber.Text)
                                {
                                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                                    string Password = employe.Password;
                                    int j = 1;
                                    sanoq = 1;
                                    employe.Password = txNewPassword.Text;
                                    foreach (AllInformations allInformations in functions.allInformations)
                                    {
                                        streamWriter1.WriteLine((j++) + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                    }
                                    streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.ChangePassword + "," + $"Parol {Password} dan {employe.Password} ga o'zgartirildi," + DateTime.Now.ToString());
                                    streamWriter1.Close();
                                }
                                streamWriter.WriteLine((i++) + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                            }
                            streamWriter.Close();
                            if (sanoq == 1)
                            {
                                MessageBox.Show($"Parol o'zgartirildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                LoginForm loginForm = new LoginForm();
                                loginForm.StartPosition = FormStartPosition.CenterScreen;
                                loginForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bunday qiymat berish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parol kamida 4 ta belgidan iborat bo'lishi lozim", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tasdiqlash kodi noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
