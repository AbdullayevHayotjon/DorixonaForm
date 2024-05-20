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
    public partial class AddPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public AddPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dgPills.DataSource = functions.pillsList;
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {
            if (functions.CheckProbel(txAddPillName.Text))
            {
                if (functions.CheckNumber(txAddPillCount.Text))
                {
                    if (functions.CheckNumber(txLifeTime.Text))
                    {
                        if (functions.CheckNumber(txAddPillPrice.Text))
                        {
                            int Id = 0;
                            int sanoq = 0;
                            using (StreamWriter streamWriter = new StreamWriter(functions.PillsListPath))
                            {
                                foreach (Pill pill in functions.pillsList)
                                {
                                    if (txAddPillName.Text.ToLower() == pill.Nomi.ToLower() && int.Parse(txLifeTime.Text) == pill.Muddati && int.Parse(txAddPillPrice.Text) == pill.Narxi)
                                    {
                                        sanoq = 1;
                                        pill.Soni = pill.Soni + int.Parse(txAddPillCount.Text);
                                        pill.QoshilganSana = DateTime.Now;
                                    }
                                    streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                                    Id = pill.Id;
                                }
                                if (sanoq == 0)
                                {
                                    streamWriter.WriteLine((Id + 1) + "," + txAddPillName.Text + "," + txAddPillCount.Text + "," + txLifeTime.Text + "," + txAddPillPrice.Text + "," + DateTime.Now.ToString());
                                }
                            }
                            int Id1 = 0;
                            using (StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath))
                            {
                                foreach (AllInformations allInformations in functions.allInformations)
                                {
                                    streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                    Id1 = Id;
                                }
                                foreach (Employe employe in functions.employeList)
                                {
                                    if (NewLogin == employe.Login)
                                    {
                                        streamWriter1.WriteLine((Id1 + 1) + "," + employe.FIO + "," + InformationType.AddPill + "," + $"Nomi={txAddPillName.Text}|Soni={txAddPillCount.Text}|Muddati={txLifeTime.Text}|Narxi={txAddPillPrice.Text}" + "," + DateTime.Now.ToString());
                                    }
                                }
                            }
                            MessageBox.Show($"Dori qo'shildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<Pill> pills = new List<Pill>();
                            foreach (Pill pill in functions.pillsList)
                            {
                                pills.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                            }
                            this.Hide();
                            AddPillForm addPillForm = new AddPillForm(NewLogin);
                            addPillForm.StartPosition = FormStartPosition.CenterScreen;
                            addPillForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Dori narxi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dori muddati bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dori soni bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dori nomi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void AddPillForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
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
            dgPills.DataSource = PillOld;

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
                    dgPills.DataSource = PillOld;
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
                    dgPills.DataSource = PillOld;
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

        private void btSearch_Click(object sender, EventArgs e)
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
                dgPills.DataSource = pillList;
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
                dgPills.DataSource = pillList;
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
                dgPills.DataSource = pillList;
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
                dgPills.DataSource = pillList;
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
                dgPills.DataSource = pillList;
            }
            else if (cbSearch.Text == "Qo'shilgan Sana")
            {
                List<Pill> pillList = new List<Pill>();
                foreach (Pill pill in functions.pillsList)
                {
                    if (pill.QoshilganSana.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                }
                dgPills.DataSource = pillList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
