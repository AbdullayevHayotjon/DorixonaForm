using DorixonaForm.Actions;
using DorixonaForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm
{
    public partial class SalesmanForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public int i = 1;
        public string FIO { get; set; }
        public SalesmanForm(string login)
        {
            NewLogin = login;
            InitializeComponent();

            dGWPills.DataSource = functions.pillsList;
            dataGridView1.DataSource = functions.sellingPillesList;
            int AllPrice = 0;
            foreach (SellingPill sellingPill in functions.sellingPillesList)
            {
                AllPrice += sellingPill.Narxi;
            }
            lbAllPrice.Text = AllPrice.ToString();
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                    FIO = employe1.FIO;
                }
            }
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

        private void btSellPill_Click(object sender, EventArgs e)
        {
            if (functions.sellingPillesList.Count > 0)
            {
                StreamWriter streamWriter1 = new StreamWriter(functions.PillsListPath);
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Soni == 0)
                    {
                        continue;
                    }
                    streamWriter1.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                }
                streamWriter1.Close();
                int Id1 = 0;
                foreach (Employe employe in functions.employeList)
                {
                    if (employe.Login == NewLogin)
                    {
                        Id1 = employe.Id;
                        break;
                    }
                }
                MessageBox.Show("Dorilar sotildi", "Muvaffaqqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StreamWriter stream = new StreamWriter(functions.AllInformationsPath);
                foreach (AllInformations allInformations in functions.allInformations)
                {
                    stream.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                }
                StreamWriter streamWriter2 = new StreamWriter(functions.ReportSelesPillsPath);
                foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
                {
                    streamWriter2.WriteLine(reportSelesPill.SotuvchiId + "," + reportSelesPill.FIO + "," + reportSelesPill.DoriId + "," + reportSelesPill.Nomi + "," + reportSelesPill.Soni + "," + reportSelesPill.SotilganVaqti + "," + reportSelesPill.Narxi);
                }
                foreach (SellingPill sellingPill in functions.sellingPillesList)
                {
                    stream.WriteLine(Id1 + "," + FIO + "," + InformationType.SalesPill.ToString() + "," + $"Id={sellingPill.Id}|Nomi={sellingPill.Nomi}|Soni={sellingPill.Soni}|Narxi={sellingPill.Narxi}" + "," + DateTime.Now.ToString());
                    streamWriter2.WriteLine(Id1 + "," + FIO + "," + sellingPill.Id + "," + sellingPill.Nomi + "," + sellingPill.Soni + "," + DateTime.Now.ToString() + "," + sellingPill.Narxi);
                }
                streamWriter2.Close();
                stream.Close();
                StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
                streamWriter.Close();
                this.Hide();
                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                salesmanForm.Show();
            }
            else
            {
                MessageBox.Show("Savat bo'sh", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btAddPill_Click(object sender, EventArgs e)
        {

        }

        private void btDeletePill_Click(object sender, EventArgs e)
        {

        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {

        }

        private void SalesmanForm_Load(object sender, EventArgs e)
        {

        }

        private void dGWPills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAddBox_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Nomi")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Nomi.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Id")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Id.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Soni")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Soni.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Muddati")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Muddati.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Narxi")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Narxi.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Qo'shilgan sanasi")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.QoshilganSana.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dGWPills.DataSource = pillList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btAddBox_Click_1(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.Id == int.Parse(txId.Text))
                    {
                        sanoq = 1;
                        if (functions.CheckNumber(txPillCount.Text) && int.Parse(txPillCount.Text) != 0)
                        {
                            sanoq = 2;
                            if (int.Parse(txPillCount.Text) <= pill.Soni)
                            {
                                sanoq = 3;
                                StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
                                foreach (SellingPill sellingPill in functions.sellingPillesList)
                                {
                                    if (sellingPill.Id == int.Parse(txId.Text))
                                    {
                                        sanoq = 4;
                                        sellingPill.Soni = sellingPill.Soni + int.Parse(txPillCount.Text);
                                    }
                                    streamWriter.WriteLine(sellingPill.Id + "," + sellingPill.Nomi + "," + sellingPill.Soni + "," + sellingPill.Narxi);
                                }
                                if (sanoq == 3)
                                {
                                    streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + txPillCount.Text + "," + pill.Narxi * int.Parse(txPillCount.Text));
                                }
                                streamWriter.Close();
                                StreamWriter streamWriter1 = new StreamWriter(functions.PillsListPath);
                                foreach (Pill pill1 in functions.pillsList)
                                {
                                    if (pill1.Id == int.Parse(txId.Text))
                                    {
                                        pill1.Soni = pill1.Soni - int.Parse(txPillCount.Text);
                                    }
                                    streamWriter1.WriteLine(pill1.Id + "," + pill1.Nomi + "," + pill1.Soni + "," + pill1.Muddati + "," + pill1.Narxi + "," + pill1.QoshilganSana);
                                }
                                streamWriter1.Close();
                                this.Hide();
                                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                                salesmanForm.Show();
                            }
                        }
                        break;
                    }
                }
                if (sanoq == 0)
                {
                    MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sanoq == 1)
                {
                    MessageBox.Show("Dori soni bunday bo'lishi mumkin emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sanoq == 2)
                {
                    MessageBox.Show("Dori soni yetmaydi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnklSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
            StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter1.Close();
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
            this.Hide();
            AddPillForm addPillForm = new AddPillForm(NewLogin);
            addPillForm.StartPosition = FormStartPosition.CenterScreen;
            addPillForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btUpdatePill_Click_1(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
            this.Hide();
            UpdatePillForm updatePillForm = new UpdatePillForm(NewLogin);
            updatePillForm.StartPosition = FormStartPosition.CenterScreen;
            updatePillForm.Show();
        }

        private void btDeletePill_Click_1(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
            this.Hide();
            DeletePillForm deletePillForm = new DeletePillForm(NewLogin);
            deletePillForm.StartPosition = FormStartPosition.CenterScreen;
            deletePillForm.Show();
        }

        private void lkSalesmanReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
            StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter1.Close();
            this.Hide();
            SalesmanReportsForm salesmanReportsForm = new SalesmanReportsForm(NewLogin);
            salesmanReportsForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanReportsForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateBasketPillForm updateBasketPillForm = new UpdateBasketPillForm(NewLogin);
            updateBasketPillForm.StartPosition = FormStartPosition.CenterScreen;
            updateBasketPillForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBasketPillForm deleteBasketPillForm = new DeleteBasketPillForm(NewLogin);
            deleteBasketPillForm.StartPosition = FormStartPosition.CenterScreen;
            deleteBasketPillForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
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
            StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter1.Close();
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
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

        private void btKamayish_Click(object sender, EventArgs e)
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

        private void btQaytarish_Click(object sender, EventArgs e)
        {
            dGWPills.DataSource = functions.pillsList;
        }
    }
}
