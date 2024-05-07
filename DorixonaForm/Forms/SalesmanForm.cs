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
        public int AllCount = 0;
        public int AllPrice = 0;
        public int i = 1;
        public SalesmanForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dGWPills.DataSource = functions.pillsList;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(NewLogin);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btSellPill_Click(object sender, EventArgs e)
        {
            List<Pill> sellingPillesList = new List<Pill>();
            string[] SellingPillesList = File.ReadAllLines(functions.SellingPillesListPath);
            for (int i = 0; i < SellingPillesList.Length; i++)
            {
                string[] SellingPillsListLine = SellingPillesList[i].Split(",");
                sellingPillesList.Add(new Pill() { Id = int.Parse(SellingPillsListLine[0]), Nomi = SellingPillsListLine[1], Soni = int.Parse(SellingPillsListLine[2]), Narxi = int.Parse(SellingPillsListLine[3]) });
            }
            if (sellingPillesList.Count > 0)
            {
                File.AppendAllText(functions.SellingPillesListPath, i.ToString() + ",Jami," + AllCount + "," + AllPrice + "\n");
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
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPillForm addPillForm = new AddPillForm(NewLogin);
            addPillForm.StartPosition = FormStartPosition.CenterScreen;
            addPillForm.Show();
        }

        private void btDeletePill_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePillForm deletePillForm = new DeletePillForm(NewLogin);
            deletePillForm.StartPosition = FormStartPosition.CenterScreen;
            deletePillForm.Show();
        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePillForm updatePillForm = new UpdatePillForm(NewLogin);
            updatePillForm.StartPosition = FormStartPosition.CenterScreen;
            updatePillForm.Show();
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
                    pillList.Add(new Pill() { Id = i++, Nomi = pill.Nomi, Soni = pill.Soni, Narxi = pill.Narxi });
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
                    if (txPillCount.Text.Length > 0 && int.Parse(txPillCount.Text) > 0)
                    {
                        if(pill.Soni - int.Parse(txPillCount.Text) >= 0)
                        {
                            File.AppendAllText(functions.SellingPillesListPath, i++.ToString() + "," + pill.Nomi + "," + txPillCount.Text + "," + pill.Narxi * int.Parse(txPillCount.Text) + "\n");
                            MessageBox.Show($"Savatga qo'shildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AllCount += int.Parse(txPillCount.Text);
                            AllPrice += pill.Narxi * int.Parse(txPillCount.Text);
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
                MessageBox.Show("Dori nomini to'g'ri kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
