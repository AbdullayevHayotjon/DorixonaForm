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
        public SalesmanForm(string login)
        {
            NewLogin = login;
            InitializeComponent();

            dGWPills.DataSource = functions.pillsList;
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
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
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btSellPill_Click(object sender, EventArgs e)
        {
            int AllCount = 0, AllPrice = 0;
            List<SellingPill> sellingPillesList = new List<SellingPill>();
            string[] SellingPillesList = File.ReadAllLines(functions.SellingPillesListPath);
            for (int i = 0; i < SellingPillesList.Length; i++)
            {
                string[] SellingPillsListLine = SellingPillesList[i].Split(",");
                sellingPillesList.Add(new SellingPill() { Id = int.Parse(SellingPillsListLine[0]), Nomi = SellingPillsListLine[1], Soni = int.Parse(SellingPillsListLine[2]), Narxi = int.Parse(SellingPillsListLine[3]) });
            }
            if (sellingPillesList.Count > 0)
            {
                foreach (SellingPill sellingPill in sellingPillesList)
                {
                    AllCount += sellingPill.Soni;
                    AllPrice += sellingPill.Narxi;
                }
                File.AppendAllText(functions.SellingPillesListPath, i + ",Jami," + AllCount + "," + AllPrice + "\n");
                this.Hide();
                SellPillForm sellPillForm = new SellPillForm(NewLogin);
                sellPillForm.StartPosition = FormStartPosition.CenterScreen;
                sellPillForm.Show();
            }
            else
            {
                MessageBox.Show("Savat bo'sh", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<Pill> pillList = new List<Pill>();
            int i = 1;
            foreach (Pill pill in functions.pillsList)
            {
                if (pill.Nomi.ToLower().Contains(txPillName.Text.ToLower()))
                {
                    pillList.Add(new Pill() { Id = i++, Nomi = pill.Nomi, Soni = pill.Soni, Muddati = pill.Muddati, Narxi = pill.Narxi, QoshilganSana = pill.QoshilganSana });
                }
            }
            dGWPills.DataSource = pillList;
        }
        private void btAddBox_Click_1(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Pill pill in functions.pillsList)
            {
                if (txPillName.Text.ToLower() == pill.Nomi.ToLower())
                {
                    sanoq = 1;
                    if (functions.CheckNumber(txPillCount.Text))
                    {
                        if (pill.Soni - int.Parse(txPillCount.Text) >= 0)
                        {
                            File.AppendAllText(functions.SellingPillesListPath, (i++) + "," + pill.Nomi + "," + txPillCount.Text + "," + pill.Narxi * int.Parse(txPillCount.Text) + "\n");
                            MessageBox.Show($"Savatga qo'shildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txPillName.Clear();
                            txPillCount.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Dori soni yetmaydi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dori sonini xato kiritdingiz", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Dori nomini to'liq kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnklSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
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
    }
}
