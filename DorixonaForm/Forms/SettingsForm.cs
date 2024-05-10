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
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public SettingsForm(string login)
        {
            NewLogin = login;
            SmsPassword = random.Next(10000, 99999);
            InitializeComponent();
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
        }
        private void btChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btChangeLogin_Click(object sender, EventArgs e)
        {

        }

        private void btChangePhoneNumber_Click(object sender, EventArgs e)
        {

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

        private void btSaveNewPassword_Click(object sender, EventArgs e)
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
                        if (txNewPassword.Text.Length >= 4)
                        {
                            sanoq = 5;
                            if (functions.CheckProbel(txNewPassword.Text))
                            {
                                sanoq = 4;
                                if (txNewPassword.Text == txNewPassword2.Text)
                                {
                                    sanoq = 2;
                                    employe.Password = txNewPassword.Text;
                                }
                            }
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
                StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                int j = 1;
                foreach (AllInformations allInformations in functions.allInformations)
                {
                    streamWriter1.WriteLine((j++) + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                }
                foreach (Employe employe in functions.employeList)
                {
                    if (NewLogin == employe.Login)
                    {
                        streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.ChangePassword + "," + $"Parol {txOldPassword.Text} dan {txNewPassword.Text} ga o'zgartirildi" + "," + DateTime.Now.ToString());
                    }
                }
                streamWriter1.Close();
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
            else if (sanoq == 5)
            {
                MessageBox.Show("Bunday qiymat berish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sanoq == 4)
            {
                MessageBox.Show("Tasdiqlash paroli noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sanoq == 1)
            {
                MessageBox.Show("Parol kamida 4 ta belgidan iborat bo'lishi lozim", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Oldingi parolingiz xato", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txSendPassword_Click(object sender, EventArgs e)
        {
            if (txNewPhoneNumber.Text.Length == 9 && functions.CheckNumber(txNewPhoneNumber.Text))
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
                    txNewPhoneNumber.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PhoneNumber = "";
            if (txNewPhoneNumber.Text.Length == 9 && functions.CheckNumber(txNewPhoneNumber.Text))
            {
                if (txSmsPassword.Text == SmsPassword.ToString())
                {
                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            PhoneNumber = employe.PhoneNumber;
                            employe.PhoneNumber = txNewPhoneNumber.Text;
                        }
                        streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                    }
                    streamWriter.Close();
                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                    int j = 1;
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        streamWriter1.WriteLine((j++) + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                    }
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.ChangePhoneNumber + "," + $"{PhoneNumber} dan {txNewPhoneNumber.Text} ga o'zgartirildi" + "," + DateTime.Now.ToString());
                        }
                    }
                    streamWriter1.Close();
                    MessageBox.Show($"Muvaffaqqiyatli o'zgartirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
