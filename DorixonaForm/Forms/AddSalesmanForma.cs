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
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    txAddFIO.Text = employe1.FIO;
                }
            }
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
                Thread.Sleep(2000);
                MessageBox.Show($"Tasdiqlash kodi: {SmsPassword}", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txAddPhoneNumber.ReadOnly = true;
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

        private void btOsish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    string EmployePath = @"..\..\..\.txt files\EmployesList.txt";
                    string[] EmployeAllLines = File.ReadAllLines(EmployePath);
                    List<Employe> EmployeOld = new List<Employe>();
                    foreach (var EmployeAllLinesItem in EmployeAllLines)
                    {
                        string[] EmployeInfo = EmployeAllLinesItem.Split(',');
                        EmployeOld.Add(new Employe
                        {
                            Id = int.Parse(EmployeInfo[0]),
                            FIO = EmployeInfo[1],
                            Login = EmployeInfo[2],
                            Password = EmployeInfo[3],
                            EmployeType = EmployeInfo[4],
                            PhoneNumber = EmployeInfo[5],
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        EmployeOld.Sort((x, y) => x.Id.CompareTo(y.Id));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        EmployeOld.Sort((x, y) =>
                        {
                            if (x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(x.FIO, y.FIO, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Login")
                    {
                        EmployeOld.Sort((x, y) => x.Login.CompareTo(y.Login));
                    }
                    else if (cbSort.Text == "Parol")
                    {
                        EmployeOld.Sort((x, y) => x.Password.CompareTo(y.Password));
                    }
                    else if (cbSort.Text == "Phone Number")
                    {
                        EmployeOld.Sort((x, y) => x.PhoneNumber.CompareTo(y.PhoneNumber));
                    }
                    dGVAddEmploye.DataSource = EmployeOld;
                }
                else
                {
                    MessageBox.Show("Xatolik mavjud tekshirib qaytadan kiriting.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Noto'g'ri formatda qiymat kiritildi.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Faylda xatolik: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik: " + ex.Message);
            }
        }

        private void btKamayish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    string EmployePath = @"..\..\..\.txt files\EmployesList.txt";
                    string[] EmployeAllLines = File.ReadAllLines(EmployePath);
                    List<Employe> EmployeOld = new List<Employe>();
                    foreach (var EmployeAllLinesItem in EmployeAllLines)
                    {
                        string[] EmployeInfo = EmployeAllLinesItem.Split(',');
                        EmployeOld.Add(new Employe
                        {
                            Id = int.Parse(EmployeInfo[0]),
                            FIO = EmployeInfo[1],
                            Login = EmployeInfo[2],
                            Password = EmployeInfo[3],
                            EmployeType = EmployeInfo[4],
                            PhoneNumber = EmployeInfo[5],
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        EmployeOld.Sort((x, y) => y.Id.CompareTo(x.Id));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        EmployeOld.Sort((x, y) =>
                        {
                            if (y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(y.FIO, x.FIO, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Login")
                    {
                        EmployeOld.Sort((x, y) => y.Login.CompareTo(x.Login));
                    }
                    else if (cbSort.Text == "Parol")
                    {
                        EmployeOld.Sort((x, y) => y.Password.CompareTo(x.Password));
                    }
                    else if (cbSort.Text == "Phone Number")
                    {
                        EmployeOld.Sort((x, y) => y.PhoneNumber.CompareTo(x.PhoneNumber));
                    }
                    dGVAddEmploye.DataSource = EmployeOld;
                }
                else
                {
                    MessageBox.Show("Xatolik mavjud tekshirib qaytadan kiriting.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Noto'g'ri formatda qiymat kiritildi.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Faylda xatolik: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik: " + ex.Message);
            }
        }

        private void btQaytarish_Click(object sender, EventArgs e)
        {
            dGVAddEmploye.DataSource = functions.employeList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Id")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.Id.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVAddEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "FIO")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.FIO.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVAddEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "Login")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.Login.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVAddEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "Parol")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.Password.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVAddEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "Phone Number")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.PhoneNumber.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVAddEmploye.DataSource = employesList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
