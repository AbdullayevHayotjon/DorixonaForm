using DorixonaForm.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm.Forms
{
    public partial class UpdatePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdatePillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dataGridView1.DataSource = functions.pillsList;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btUpdatePill_Click(object sender, EventArgs e)
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
                    if (functions.CheckProbel(txUpdatePillName.Text))
                    {
                        if (functions.CheckNumber(txUpdatePillCount.Text))
                        {
                            if (functions.CheckNumber(txUpdatePillLifeTime.Text))
                            {
                                if (functions.CheckNumber(txUpdatePillPrice.Text))
                                {
                                    foreach (Pill pill in functions.pillsList)
                                    {
                                        if (int.Parse(txId.Text) == pill.Id)
                                        {
                                            pill.Nomi = txUpdatePillName.Text;
                                            pill.Soni = int.Parse(txUpdatePillCount.Text);
                                            pill.Muddati = int.Parse(txUpdatePillLifeTime.Text);
                                            pill.Narxi = int.Parse(txUpdatePillPrice.Text);
                                            break;
                                        }
                                    }
                                    List<Pill> pills = new List<Pill>();
                                    StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                                    foreach (Pill pill in functions.pillsList)
                                    {
                                        streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                                        pills.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                                    }
                                    streamWriter.Close();
                                    int Id = 0;
                                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                                    foreach (AllInformations allInformations in functions.allInformations)
                                    {
                                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                        Id = allInformations.Id;
                                    }
                                    foreach (Employe employe in functions.employeList)
                                    {
                                        if (NewLogin == employe.Login)
                                        {
                                            streamWriter1.WriteLine((Id + 1) + "," + employe.FIO + "," + InformationType.UpdatePill + "," + $"|Nomi: {txUpdatePillName.Text}|Soni: {txUpdatePillCount.Text}|Muddati: {txUpdatePillLifeTime.Text}|Narxi: {txUpdatePillPrice.Text}|" + "," + DateTime.Now.ToString());
                                        }
                                    }
                                    streamWriter1.Close();
                                    MessageBox.Show($"Dori yangilandi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dataGridView1.DataSource = pills;
                                    txUpdatePillName.Clear();
                                    txUpdatePillCount.Clear();
                                    txUpdatePillLifeTime.Clear();
                                    txUpdatePillPrice.Clear();
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

        private void UpdatePillForm_Load(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            List<Pill> pillList = new List<Pill>();
            foreach (Pill pill in functions.pillsList)
            {
                if (pill.Nomi.ToLower().Contains(txPillName.Text.ToLower()))
                {
                    pillList.Add(new Pill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                }
            }
            dataGridView1.DataSource = pillList;
        }

        private void btPlacement_Click(object sender, EventArgs e)
        {
            if (txId.Text.Length == 0)
            {
                txUpdatePillName.Clear();
                txUpdatePillCount.Clear();
                txUpdatePillLifeTime.Clear();
                txUpdatePillPrice.Clear();
            }
            else if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Pill pill in functions.pillsList)
                {
                    if (int.Parse(txId.Text) == pill.Id)
                    {
                        sanoq = 1;
                        txUpdatePillName.Text = pill.Nomi;
                        txUpdatePillCount.Text = pill.Soni.ToString();
                        txUpdatePillLifeTime.Text = pill.Muddati.ToString();
                        txUpdatePillPrice.Text = pill.Narxi.ToString();
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
    }
}
