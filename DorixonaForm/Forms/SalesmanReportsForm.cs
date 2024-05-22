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
    public partial class SalesmanReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public List<SalesmanReport> salesmanReports = new List<SalesmanReport>();
        public SalesmanReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            string FIO = "";
            foreach (Employe employe in functions.employeList)
            {
                if (NewLogin == employe.Login)
                {
                    FIO = employe.FIO;
                }
            }
            foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
            {
                if (FIO == reportSelesPill.FIO)
                {
                    salesmanReports.Add(new SalesmanReport() { Id = reportSelesPill.DoriId, Nomi = reportSelesPill.Nomi, Soni = reportSelesPill.Soni, SotilganVaqti = reportSelesPill.SotilganVaqti, Narxi = reportSelesPill.Narxi });
                }
            }
            dGWPills.DataSource = salesmanReports;
        }

        private void SalesmanReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
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
            foreach (SellingPill sellingPill in functions.sellingPillesList)
            {
                foreach (Pill pill in functions.pillsList)
                {
                    if (sellingPill.Id == pill.Id)
                    {
                        pill.Soni = pill.Soni + sellingPill.Soni;
                        break;
                    }
                }
            }
            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
            foreach (Pill pill1 in functions.pillsList)
            {
                streamWriter.WriteLine(pill1.Id + "," + pill1.Nomi + "," + pill1.Soni + "," + pill1.Muddati + "," + pill1.Narxi + "," + pill1.QoshilganSana);
            }
            streamWriter.Close();
            StreamWriter streamWriter2 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter2.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    string PillPath = @"..\..\..\.txt files\PillesList.txt";
                    string[] PillAllLines = File.ReadAllLines(PillPath);
                    List<Pill> PillOld = new List<Pill>();
                    foreach (var PillAllLinesItem in PillAllLines)
                    {
                        string[] PillInfo = PillAllLinesItem.Split(',');
                        PillOld.Add(new Pill
                        {
                            Id = int.Parse(PillInfo[0]),
                            Nomi = PillInfo[1],
                            Soni = int.Parse(PillInfo[2]),
                            Muddati = int.Parse(PillInfo[3]),
                            Narxi = int.Parse(PillInfo[4]),
                            QoshilganSana = DateTime.Parse(PillInfo[5]),
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        PillOld.Sort((x, y) => x.Id.CompareTo(y.Id));
                    }
                    else if (cbSort.Text == "Nomi")
                    {
                        PillOld.Sort((x, y) =>
                        {
                            if (x.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !y.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!x.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase) && y.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(x.Nomi, y.Nomi, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Soni")
                    {
                        PillOld.Sort((x, y) => x.Soni.CompareTo(y.Soni));
                    }
                    else if (cbSort.Text == "Muddati")
                    {
                        PillOld.Sort((x, y) => x.Muddati.CompareTo(y.Muddati));
                    }
                    else if (cbSort.Text == "Narxi")
                    {
                        PillOld.Sort((x, y) => x.Narxi.CompareTo(y.Narxi));
                    }
                    else if (cbSort.Text == "Qo'shilgan sanasi")
                    {
                        PillOld.Sort((x, y) => x.QoshilganSana.CompareTo(y.QoshilganSana));
                    }
                    dGWPills.DataSource = PillOld;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Price = 0;
            int Count = 0;
            DateTime Kun1 = DateTime.Parse(dTKun1.Text).Date;
            DateTime Kun2 = DateTime.Parse(dTKun2.Text).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            List<SalesmanReport> list = new List<SalesmanReport>();
            if (txId.Text.Length == 0)
            {
                if (Kun2 >= Kun1)
                {
                    foreach (SalesmanReport salesmanReport in salesmanReports)
                    {
                        if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                        {
                            list.Add(new SalesmanReport() { Id = salesmanReport.Id, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                            Price += salesmanReport.Narxi;
                            Count += salesmanReport.Soni;
                        }
                    }
                    lbPrice.Text = Price.ToString();
                    lbCount.Text = Count.ToString();
                    dGWPills.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (functions.CheckNumber(txId.Text))
            {
                if (Kun2 >= Kun1)
                {
                    int sanoq = 0;
                    foreach (SalesmanReport salesmanReport in salesmanReports)
                    {
                        if (salesmanReport.Id == int.Parse(txId.Text))
                        {
                            sanoq = 1;
                            if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                            {
                                sanoq = 2;
                                list.Add(new SalesmanReport() { Id = salesmanReport.Id, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                                Price += salesmanReport.Narxi;
                                Count += salesmanReport.Soni;
                            }
                        }
                    }
                    if (sanoq == 0)
                    {
                        MessageBox.Show("Bunday Id mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lbCount.Text = Count.ToString();
                        lbPrice.Text = Price.ToString();
                        dGWPills.DataSource = list;
                    }
                }
                else
                {
                    MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Id bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    string PillPath = @"..\..\..\.txt files\PillesList.txt";
                    string[] PillAllLines = File.ReadAllLines(PillPath);
                    List<Pill> PillOld = new List<Pill>();
                    foreach (var PillAllLinesItem in PillAllLines)
                    {
                        string[] PillInfo = PillAllLinesItem.Split(',');
                        PillOld.Add(new Pill
                        {
                            Id = int.Parse(PillInfo[0]),
                            Nomi = PillInfo[1],
                            Soni = int.Parse(PillInfo[2]),
                            Muddati = int.Parse(PillInfo[3]),
                            Narxi = int.Parse(PillInfo[4]),
                            QoshilganSana = DateTime.Parse(PillInfo[5])
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        PillOld.Sort((x, y) => y.Id.CompareTo(x.Id));
                    }
                    else if (cbSort.Text == "Nomi")
                    {
                        PillOld.Sort((x, y) =>
                        {
                            if (y.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !x.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!y.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase) && x.Nomi.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(y.Nomi, x.Nomi, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Soni")
                    {
                        PillOld.Sort((x, y) => y.Soni.CompareTo(x.Soni));
                    }
                    else if (cbSort.Text == "Muddati")
                    {
                        PillOld.Sort((x, y) => y.Muddati.CompareTo(x.Muddati));
                    }
                    else if (cbSort.Text == "Narxi")
                    {
                        PillOld.Sort((x, y) => y.Narxi.CompareTo(x.Narxi));
                    }
                    else if (cbSort.Text == "Qo'shilgan sanasi")
                    {
                        PillOld.Sort((x, y) => y.QoshilganSana.CompareTo(x.QoshilganSana));

                    }
                    dGWPills.DataSource = PillOld;
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

        private void button9_Click(object sender, EventArgs e)
        {
            dGWPills.DataSource = functions.pillsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Nomi")
            {
                List<SalesmanReport> pillList = new List<SalesmanReport>();
                foreach (SalesmanReport pill in salesmanReports)
                {
                    if (pill.Nomi.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        pillList.Add(new SalesmanReport() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, SotilganVaqti = pill.SotilganVaqti, Narxi = pill.Narxi });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Id")
            {
                List<SalesmanReport> pillList = new List<SalesmanReport>();
                foreach (SalesmanReport pill in salesmanReports)
                {
                    if (pill.Id.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SalesmanReport() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, SotilganVaqti = pill.SotilganVaqti, Narxi = pill.Narxi });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Soni")
            {
                List<SalesmanReport> pillList = new List<SalesmanReport>();
                foreach (SalesmanReport pill in salesmanReports)
                {
                    if (pill.Soni.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SalesmanReport() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, SotilganVaqti = pill.SotilganVaqti, Narxi = pill.Narxi });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Sotilgan vaqti")
            {
                List<SalesmanReport> pillList = new List<SalesmanReport>();
                foreach (SalesmanReport pill in salesmanReports)
                {
                    if (pill.SotilganVaqti.Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SalesmanReport() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, SotilganVaqti = pill.SotilganVaqti, Narxi = pill.Narxi });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Narxi")
            {
                List<SalesmanReport> pillList = new List<SalesmanReport>();
                foreach (SalesmanReport pill in salesmanReports)
                {
                    if (pill.Narxi.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SalesmanReport() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, SotilganVaqti = pill.SotilganVaqti, Narxi = pill.Narxi });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanReportsForm salesmanReportsForm = new SalesmanReportsForm(NewLogin);
            salesmanReportsForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanReportsForm.Show();
        }
    }
}
