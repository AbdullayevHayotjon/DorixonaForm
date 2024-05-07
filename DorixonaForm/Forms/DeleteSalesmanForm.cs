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
    public partial class txDeleteSalesmanForm : Form
    {
        Functions functions = new Functions();
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public txDeleteSalesmanForm(string login)
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

        private void txSendPassword_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employeInformation in functions.employeList)
            {
                if (employeInformation.PhoneNumber == txDeletePhoneNumber.Text)
                {
                    sanoq = 1;
                    MessageBox.Show($"Sotuvchi FIOsi: {employeInformation.FIO}", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(2000);
                    MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Telefon raqam mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {
            if(txDeletePhoneNumber.Text.Length > 0)
            {
                if (txDeleteSmsPassword.Text == SmsPassword.ToString())
                {
                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                    foreach (Employe employe in functions.employeList)
                    {
                        if(txDeletePhoneNumber.Text == employe.PhoneNumber)
                        {
                            continue;
                        }
                        streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                    }
                    streamWriter.Close();
                    MessageBox.Show($"Sotuvchi o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(2000);
                    MessageBox.Show($"Muvaffaqqiyatli o'chirildingiz", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(NewLogin);
                    managerForm.StartPosition = FormStartPosition.CenterScreen;
                    managerForm.Show();
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
    }
}
