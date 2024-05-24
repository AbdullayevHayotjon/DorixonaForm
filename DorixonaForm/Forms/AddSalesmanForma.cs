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
    public partial class AddSalesmanForma : Form
    {
        Functions functions = new Functions();
        public Random random = new Random();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public AddSalesmanForma(string login)
        {
            NewLogin = login;
            SmsPassword = random.Next(10000, 99999);
            InitializeComponent();
            dGVAddEmploye.DataSource = functions.employeList;
        }

        private void lbAddSmsPassword_Click(object sender, EventArgs e)
        {

        }

        private void AddSalesmanForma_Load(object sender, EventArgs e)
        {

        }

        private void btAddSmsPassword_Click(object sender, EventArgs e)
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
                if (txAddPhoneNumber.Text.Length == 9 && functions.CheckNumber(txAddPhoneNumber.Text))
                {
                    Thread.Sleep(2000);
                    MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txAddPhoneNumber.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btSaqlash_Click(object sender, EventArgs e)
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
                                    List<Employe> employes = new List<Employe>();
                                    int Id = 0;
                                    foreach (Employe employe in functions.employeList)
                                    {
                                        streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                                        employes.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                                        Id = employe.Id;
                                    }
                                    streamWriter.WriteLine((Id + 1) + "," + txAddFIO.Text + "," + txAddLogin.Text + "," + txAddPassword.Text + "," + txAddPhoneNumber.Text + "," + EmployeType.Salesman.ToString());
                                    employes.Add(new Employe() { Id = Id + 1, FIO = txAddFIO.Text, Login = txAddLogin.Text, Password = txAddPassword.Text, PhoneNumber = txAddPhoneNumber.Text, EmployeType = EmployeType.Salesman.ToString() });
                                    streamWriter.Close();
                                    MessageBox.Show($"Sotuvchi qo'shildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                                    foreach (AllInformations allInformations in functions.allInformations)
                                    {
                                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                    }
                                    foreach (Employe employe in functions.employeList)
                                    {
                                        if (NewLogin == employe.Login)
                                        {
                                            streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.AddSalesman + "," + $"|FIO: {txAddFIO.Text}|Telefon raqami: {txAddPhoneNumber.Text}|" + "," + DateTime.Now.ToString());
                                        }
                                    }
                                    streamWriter1.Close();
                                    dGVAddEmploye.DataSource = employes;
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

        private void btOsish_Click(object sender, EventArgs e)
        {
        }

        private void btQaytarish_Click(object sender, EventArgs e)
        {
            dGVAddEmploye.DataSource = functions.employeList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "FIO")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.FIO.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else if (cbSearch.Text == "Id")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.Id.ToString().Contains(txPillInformation.Text))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else if (cbSearch.Text == "Login")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.Login.Contains(txPillInformation.Text))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else if (cbSearch.Text == "Password")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.Password.Contains(txPillInformation.Text))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else if (cbSearch.Text == "PhoneNumber")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.PhoneNumber.Contains(txPillInformation.Text))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else if (cbSearch.Text == "EmployeType")
            {
                List<Employe> employeList = new List<Employe>();
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.EmployeType.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                }
                dGVAddEmploye.DataSource = employeList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dGVAddEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void AddSalesmanForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
            foreach (AllInformations allInformations in functions.allInformations)
            {
                streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
            }
            foreach (Employe employe in functions.employeList)
            {
                if (NewLogin == employe.Login)
                {
                    streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.EmployeExit + "," + "Profildan chiqdi" + "," + DateTime.Now.ToString());
                }
            }
            streamWriter1.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }
    }
}





