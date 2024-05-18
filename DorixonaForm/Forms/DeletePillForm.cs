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
    public partial class DeletePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeletePillForm(string login)
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
                    int Id = 0;
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                        Id = allInformations.Id;
                    }
                    foreach (Employe employe in functions.employeList)
                    {
                        if (NewLogin == employe.Login)
                        {
                            streamWriter1.WriteLine((Id + 1) + "," + employe.FIO + "," + InformationType.DeletePill + "," + $"{txDeletePillName.Text} nomli dori o'chirildi" + "," + DateTime.Now.ToString());
                        }
                    }
                    streamWriter1.Close();
                    MessageBox.Show($"Dori o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = pills;
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
    }
}
