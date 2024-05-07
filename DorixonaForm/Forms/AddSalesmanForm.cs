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
    public partial class AddSalesmanForm : Form
    {
        Functions functions = new Functions();
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public AddSalesmanForm(string login)
        {
            NewLogin = login;
            SmsPassword = random.Next(10000, 99999);
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void txConfirmation_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employeInformation in functions.employeList)
            {
                if (employeInformation.PhoneNumber == txAddPhoneNumber.Text)
                {
                    sanoq = 1;
                    MessageBox.Show("Bu raqam oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (sanoq == 0)
            {
                Thread.Sleep(1000);
                MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSaveNewLogPass_Click(object sender, EventArgs e)
        {
            if (txAddPhoneNumber.Text.Length > 0)
            {
                if (txAddSmsPassword.Text == SmsPassword.ToString())
                {
                    int sanoq = 0;
                    foreach (Employe employe in functions.employeList)
                    {
                        if (employe.Login == txAddLogin.Text)
                        {
                            sanoq = 1;
                        }
                    }
                    if (txAddLogin.Text.Length > 0 || txAddPassword.Text.Length > 0 || txAddFIO.Text.Length > 0)
                    {
                        if (sanoq == 0)
                        {
                            StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                            int i = 1;
                            foreach (Employe employe in functions.employeList)
                            {
                                streamWriter.WriteLine(i++.ToString() + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                            }
                            streamWriter.WriteLine(i.ToString() + "," + txAddFIO.Text + "," + txAddLogin.Text + "," + txAddPassword.Text + "," + txAddPhoneNumber.Text + "," + EmployeType.Salesman.ToString());
                            streamWriter.Close();
                            Thread.Sleep(1000);
                            MessageBox.Show($"FIO: {txAddFIO.Text}\nLoginingiz: {txAddLogin.Text}\nParolingiz: {txAddPassword.Text}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ManagerForm managerForm = new ManagerForm(NewLogin);
                            managerForm.StartPosition = FormStartPosition.CenterScreen;
                            managerForm.Show();
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
