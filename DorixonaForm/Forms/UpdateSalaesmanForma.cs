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
    public partial class UpdateSalaesmanForma : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdateSalaesmanForma(string login)
        {
            NewLogin = login;
            InitializeComponent();
            DGVupdate.DataSource = functions.employeList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Employe employe in functions.employeList)
                {
                    if (int.Parse(txId.Text) == employe.Id)
                    {
                        sanoq = 1;
                        txFio.Text = employe.FIO;
                        txTel.Text = employe.PhoneNumber.ToString();
                        txLogin.Text = employe.Login.ToString();
                        txParol.Text = employe.Password.ToString();
                        break;
                    }

                }
                if (sanoq == 0)
                {
                    MessageBox.Show("Bunday Id topilmadi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bunday Id topilmadi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (functions.CheckProbel(txFio.Text))
            {
                if (functions.CheckNumber(txTel.Text) && txTel.Text.Length == 9)
                {
                    if (functions.CheckProbel(txLogin.Text))
                    {
                        int sanoq = 0;
                        string Login = "";
                        foreach (Employe employe in functions.employeList)
                        {
                            if (int.Parse(txId.Text) == employe.Id)
                            {
                                Login = employe.Login;
                                break;
                            }
                        }
                        foreach (Employe employe in functions.employeList)
                        {
                            if (employe.Login != Login)
                            {
                                if (employe.Login == txLogin.Text)
                                {
                                    sanoq = 1;
                                }
                            }
                        }
                        if (sanoq == 0)
                        {
                            if (functions.CheckProbel(txParol.Text) && txParol.Text.Length >= 4)
                            {
                                foreach (Employe employe in functions.employeList)
                                {
                                    if (int.Parse(txId.Text) == employe.Id)
                                    {
                                        employe.FIO = txFio.Text;
                                        employe.PhoneNumber = txTel.Text;
                                        employe.Login = txLogin.Text;
                                        employe.Password = txParol.Text;
                                        break;
                                    }
                                }
                                List<Employe> employes = new List<Employe>();
                                StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                                foreach (Employe employe in functions.employeList)
                                {
                                    streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                                    employes.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                                }
                                streamWriter.Close();
                                int Id = 0;
                                StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                                foreach (AllInformations allInformations in functions.allInformations)
                                {
                                    streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                    Id = allInformations.Id;
                                }
                                streamWriter1.Close();
                                MessageBox.Show($"Yangilandi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DGVupdate.DataSource = employes;
                                txFio.Clear();
                                txTel.Clear();
                                txLogin.Clear();
                                txParol.Clear();
                                txId.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Parol bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu login oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("FIO bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UpdateSalaesmanForma_Load(object sender, EventArgs e)
        {

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
                        employeList.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType});
                    }
                }
                DGVupdate.DataSource = employeList;
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
                DGVupdate.DataSource = employeList;
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
                DGVupdate.DataSource = employeList;
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
                DGVupdate.DataSource = employeList;
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
                DGVupdate.DataSource = employeList;
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
                DGVupdate.DataSource = employeList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

