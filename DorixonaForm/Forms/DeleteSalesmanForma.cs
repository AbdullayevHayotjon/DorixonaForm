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
    public partial class DeleteSalesmanForma : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeleteSalesmanForma(string login)
        {
            NewLogin = login;
            InitializeComponent();
            DGVdelete.DataSource = functions.employeList;
        }

        private void DeleteSalesmanForma_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
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

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new(NewLogin);
            managerForm.Show();
        }

        private void DGVdelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                DGVdelete.DataSource = employeList;
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
                DGVdelete.DataSource = employeList;
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
                DGVdelete.DataSource = employeList;
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
                DGVdelete.DataSource = employeList;
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
                DGVdelete.DataSource = employeList;
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
                DGVdelete.DataSource = employeList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Employe employe in functions.employeList)
                {
                    if (int.Parse(txId.Text) == employe.Id)
                    {
                        sanoq = 1;
                    }
                }
                if (sanoq == 1)
                {
                    StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
                    List<Employe> employes = new List<Employe>();
                    int i = 1, j = 1;
                    foreach (Employe employe in functions.employeList)
                    {
                        if (int.Parse(txId.Text) == employe.Id)
                        {
                            continue;
                        }
                        streamWriter.WriteLine((i++) + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
                        employes.Add(new Employe() { Id = j++, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
                    }
                    streamWriter.Close();
                    MessageBox.Show($"Sotuvchi o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                    }
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.DeteleSalesman + "," + $"|FIO: {txFio.Text}|Telefon raqami: {txTel.Text}|" + "," + DateTime.Now.ToString());
                        }
                    }
                    streamWriter1.Close();
                    DGVdelete.DataSource = employes;
                    txId.Clear();
                    txFio.Clear();
                    txTel.Clear();
                }
                else
                {
                    MessageBox.Show("Bunday id mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Id bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}


