using DorixonaForm.Actions;
using Microsoft.VisualBasic.Logging;
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
            InitializeComponent();
            List<Employe> employes = new List<Employe>();
            int i = 1;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.EmployeType == EmployeType.Manager.ToString())
                {
                    continue;
                }
                employes.Add(new Employe() { Id = i++, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber });
            }
            dGVAddEmploye.DataSource = employes;
            NewLogin = login;
            SmsPassword = random.Next(10000, 99999);
            InitializeComponent();
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
                Thread.Sleep(2000);
                MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txAddPhoneNumber.ReadOnly = true;
            }
        }

        private void btSaveNewLogPass_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txAddPhoneNumber.Text) && txAddPhoneNumber.Text.Length == 9)
            {
                if (txAddSmsPassword.Text == SmsPassword.ToString())
                {
                    if (functions.CheckProbel(txAddFIO.Text))
                    {
                        if (functions.CheckProbel(txAddLogin.Text) && txAddLogin.Text.Length >= 4)
                        {
                            if (txAddPassword.Text.Length >= 4 && functions.CheckProbel(txAddPassword.Text))
                            {
                                int sanoq = 0;
                                foreach (Employe employe in functions.employeList)
                                {
                                    if (employe.Login == txAddLogin.Text)
                                    {
                                        sanoq = 1;
                                    }
                                }
                                if (sanoq == 1)
                                {
                                    MessageBox.Show("Bu login oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                                    int i = 1;
                                    foreach (Employe employe in functions.employeList)
                                    {
                                        streamWriter.WriteLine((i++) + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                                    }
                                    streamWriter.WriteLine(i + "," + txAddFIO.Text + "," + txAddLogin.Text + "," + txAddPassword.Text + "," + txAddPhoneNumber.Text + "," + EmployeType.Salesman.ToString());
                                    streamWriter.Close();
                                    MessageBox.Show($"Sotuvchi qo'shildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                            streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.AddSalesman + "," + $"|FIO: {txAddFIO.Text}|Telefon raqami: {txAddPhoneNumber.Text}|" + "," + DateTime.Now.ToString());
                                        }
                                    }
                                    streamWriter1.Close();
                                    Thread.Sleep(2000);
                                    MessageBox.Show($"FIO: {txAddFIO.Text}\nLoginingiz: {txAddLogin.Text}\nParolingiz: {txAddPassword.Text}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    ManagerForm managerForm = new ManagerForm(NewLogin);
                                    managerForm.StartPosition = FormStartPosition.CenterScreen;
                                    managerForm.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Parol kamida 4 ta belgidan iborat bo'lishi lozim", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login kamida 4 ta belgidan iborat bo'lishi lozim", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("FIO bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void AddSalesmanForm_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.Show();
            this.Hide();
        }

        private void dGVAddEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
