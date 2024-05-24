﻿using DorixonaForm.Actions;
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
    public partial class DeletePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeletePillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dataGridViewPills.DataSource = functions.pillsList;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btDeletePill_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Pill pill in functions.pillsList)
                {
                    if (int.Parse(txId.Text) == pill.Id)
                    {
                        sanoq = 1;
                    }
                }
                if (sanoq == 1)
                {
                    int i = 1, j = 1;
                    List<Pill> pills = new List<Pill>();
                    StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                    foreach (Pill pill in functions.pillsList)
                    {
                        if (int.Parse(txId.Text) == pill.Id)
                        {
                            continue;
                        }
                        streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                        pills.Add(new Pill() { Id = j++, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                    }
                    streamWriter.Close();
                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                    }
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.DeletePill + "," + $"{txDeletePillName.Text} nomli dori o'chirildi" + "," + DateTime.Now.ToString());
                        }
                    }
                    streamWriter1.Close();
                    MessageBox.Show($"Dori o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewPills.DataSource = pills;
                    txId.Clear();
                    txDeletePillName.Clear();
                    txDeletePillCount.Clear();
                    txDeletePillLifeTime.Clear();
                    txDeletePillPrice.Clear();
                }
                else
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
                dataGridViewPills.DataSource = pillList;
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
                dataGridViewPills.DataSource = pillList;
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
                dataGridViewPills.DataSource = pillList;
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
                dataGridViewPills.DataSource = pillList;
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
                dataGridViewPills.DataSource = pillList;
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
                dataGridViewPills.DataSource = pillList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btPlacement_Click(object sender, EventArgs e)
        {
            if (txId.Text.Length == 0)
            {
                txDeletePillName.Clear();
                txDeletePillCount.Clear();
                txDeletePillLifeTime.Clear();
                txDeletePillPrice.Clear();
            }
            else if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Pill pill in functions.pillsList)
                {
                    if (int.Parse(txId.Text) == pill.Id)
                    {
                        sanoq = 1;
                        txDeletePillName.Text = pill.Nomi;
                        txDeletePillCount.Text = pill.Soni.ToString();
                        txDeletePillLifeTime.Text = pill.Muddati.ToString();
                        txDeletePillPrice.Text = pill.Narxi.ToString();
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

        private void DeletePillForm_Load(object sender, EventArgs e)
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
            dataGridViewPills.DataSource = PillOld;
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
                    dataGridViewPills.DataSource = PillOld;
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
                    dataGridViewPills.DataSource = PillOld;
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
    }
}
