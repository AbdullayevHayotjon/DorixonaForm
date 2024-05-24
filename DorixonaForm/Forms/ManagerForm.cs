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
    public partial class ManagerForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public static List<SalesmanReport> ConsolidateSalesmanReports(List<SalesmanReport> reports)
        {
            Dictionary<int, SalesmanReport> consolidatedReports = new Dictionary<int, SalesmanReport>();

            foreach (var report in reports)
            {
                if (consolidatedReports.ContainsKey(report.Id))
                {
                    consolidatedReports[report.Id].Soni += report.Soni;
                }
                else
                {
                    consolidatedReports[report.Id] = new SalesmanReport
                    {
                        Id = report.Id,
                        Nomi = report.Nomi,
                        Soni = report.Soni,
                        SotilganVaqti = report.SotilganVaqti,
                        Narxi = report.Narxi
                    };
                }
            }

            return consolidatedReports.Values.ToList();
        }
        public ManagerForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            List<Employe> employes = new List<Employe>();
            foreach (Employe employe in functions.employeList)
            {
                employes.Add(new Employe() { Id = employe.Id, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber, EmployeType = employe.EmployeType });
            }
            dGVEmploye.DataSource = employes;
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
            List<Pill> pillLessList = new List<Pill>();
            foreach (Pill pill in functions.pillsList)
            {
                if (pill.Soni <= 10)
                {
                    pillLessList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                }
            }
            dgwLess.DataSource = pillLessList;

            List<SalesmanReport> pillManyList = new List<SalesmanReport>();
            List<SalesmanReport> pillManyList2 = new List<SalesmanReport>();
            foreach (ReportSelesPill reportSelesPillItem in functions.reportSelesPills)
            {

                pillManyList.Add(new SalesmanReport() { Id = reportSelesPillItem.DoriId, Nomi = reportSelesPillItem.Nomi, Soni = reportSelesPillItem.Soni, SotilganVaqti = reportSelesPillItem.SotilganVaqti, Narxi = reportSelesPillItem.Narxi });
            }
            List<SalesmanReport> consolidatedList = ConsolidateSalesmanReports(pillManyList);
            consolidatedList.Sort((x, y) => y.Soni.CompareTo(x.Soni));
            DateTime dateTimeOld = DateTime.Now.AddMonths(-1);
            DateTime dateTimeNow = DateTime.Now;
            int sanoq = 0;
            foreach (SalesmanReport consolidatedReport in consolidatedList)
            {
                if(dateTimeOld <= DateTime.Parse(consolidatedReport.SotilganVaqti) && DateTime.Parse(consolidatedReport.SotilganVaqti) <= dateTimeNow)
                {
                    if(sanoq < 5)
                    {
                        pillManyList2.Add(new SalesmanReport() { Id = consolidatedReport.Id, Nomi = consolidatedReport.Nomi, Soni = consolidatedReport.Soni, SotilganVaqti = consolidatedReport.SotilganVaqti, Narxi = consolidatedReport.Narxi });
                        sanoq++;
                    }
                }
            }
            dgwMany.DataSource = pillManyList2;

        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void btAddSalesman_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {

        }

        private void btReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportsForm = new ReportsForm(NewLogin);
            reportsForm.StartPosition = FormStartPosition.CenterScreen;
            reportsForm.Show();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbFIO_Click(object sender, EventArgs e)
        {

        }

        private void lnklSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                    streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.EmployeExit + "," + "Profildan chiqdi" + "," + DateTime.Now.ToString());
                }
            }
            streamWriter1.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btUpdateSalesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSalaesmanForma updateSalaesmanForma = new UpdateSalaesmanForma(NewLogin);
            updateSalaesmanForma.StartPosition = FormStartPosition.CenterScreen;
            updateSalaesmanForma.Show();
        }

        private void btAddSalesman_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddSalesmanForma addSalesmanForma = new AddSalesmanForma(NewLogin);
            addSalesmanForma.StartPosition = FormStartPosition.CenterScreen;
            addSalesmanForma.Show();

        }

        private void btDeleteSalesman_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DeleteSalesmanForma deleteSalesmanForma = new DeleteSalesmanForma(NewLogin);
            deleteSalesmanForma.StartPosition = FormStartPosition.CenterScreen;
            deleteSalesmanForma.Show();
        }

        private void btOsish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    List<Employe> EmployeOld = new List<Employe>();
                    foreach (var EmployeAllLinesItem in functions.employeList)
                    {
                        EmployeOld.Add(new Employe
                        {
                            Id = EmployeAllLinesItem.Id,
                            FIO = EmployeAllLinesItem.FIO,
                            Login = EmployeAllLinesItem.Login,
                            Password = EmployeAllLinesItem.Password,
                            EmployeType = EmployeAllLinesItem.EmployeType,
                            PhoneNumber = EmployeAllLinesItem.PhoneNumber,
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
                    dGVEmploye.DataSource = EmployeOld;
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
                    List<Employe> EmployeOld = new List<Employe>();
                    foreach (var EmployeAllLinesItem in functions.employeList)
                    {
                        EmployeOld.Add(new Employe
                        {
                            Id = EmployeAllLinesItem.Id,
                            FIO = EmployeAllLinesItem.FIO,
                            Login = EmployeAllLinesItem.Login,
                            Password = EmployeAllLinesItem.Password,
                            EmployeType = EmployeAllLinesItem.EmployeType,
                            PhoneNumber = EmployeAllLinesItem.PhoneNumber,
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
                    dGVEmploye.DataSource = EmployeOld;
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
            dGVEmploye.DataSource = functions.employeList;
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
                dGVEmploye.DataSource = employesList;
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
                dGVEmploye.DataSource = employesList;
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
                dGVEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "Password")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.Password.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVEmploye.DataSource = employesList;
            }
            else if (cbSearch.Text == "PhoneNumber")
            {
                List<Employe> employesList = new List<Employe>();
                foreach (Employe employeItem in functions.employeList)
                {
                    if (employeItem.PhoneNumber.ToString().Contains(txPillInformation.Text))
                    {
                        employesList.Add(new Employe() { Id = employeItem.Id, FIO = employeItem.FIO, Login = employeItem.Login, Password = employeItem.Password, EmployeType = employeItem.EmployeType, PhoneNumber = employeItem.PhoneNumber });
                    }
                }
                dGVEmploye.DataSource = employesList;
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
                dGVEmploye.DataSource = employeList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HelpReportsForm helpReportsForm = new HelpReportsForm(NewLogin);
            helpReportsForm.StartPosition = FormStartPosition.CenterScreen;
            helpReportsForm.Show();
        }
    }
}
