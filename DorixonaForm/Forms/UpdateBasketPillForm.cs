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
    public partial class UpdateBasketPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdateBasketPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dataGridView1.DataSource = functions.sellingPillesList;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBasketPillForm_Load(object sender, EventArgs e)
        {

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

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Nomi")
            {
                List<SellingPill> pillList = new List<SellingPill>();
                foreach (SellingPill pill in functions.sellingPillesList)
                {
                    if (pill.Nomi.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        pillList.Add(new SellingPill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Narxi = pill.Narxi, });
                    }
                }
                dataGridView1.DataSource = pillList;
            }
            else if (cbSearch.Text == "Id")
            {
                List<SellingPill> pillList = new List<SellingPill>();
                foreach (SellingPill pill in functions.sellingPillesList)
                {
                    if (pill.Id.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SellingPill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Narxi = pill.Narxi, });
                    }
                }
                dataGridView1.DataSource = pillList;
            }
            else if (cbSearch.Text == "Soni")
            {
                List<SellingPill> pillList = new List<SellingPill>();
                foreach (SellingPill pill in functions.sellingPillesList)
                {
                    if (pill.Soni.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SellingPill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Narxi = pill.Narxi, });
                    }
                }
                dataGridView1.DataSource = pillList;
            }
            else if (cbSearch.Text == "Narxi")
            {
                List<SellingPill> pillList = new List<SellingPill>();
                foreach (SellingPill pill in functions.sellingPillesList)
                {
                    if (pill.Narxi.ToString().Contains(txPillInformation.Text))
                    {
                        pillList.Add(new SellingPill() { Id = pill.Id, Nomi = pill.Nomi, Soni = pill.Soni, Narxi = pill.Narxi });
                    }
                }
                dataGridView1.DataSource = pillList;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btPlacement_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (SellingPill sellingPill in functions.sellingPillesList)
                {
                    if (sellingPill.Id == int.Parse(txId.Text))
                    {
                        sanoq = 1;
                        txUpdatePillCount.Text = sellingPill.Soni.ToString();
                        break;
                    }
                }
                if (sanoq == 0)
                {
                    MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                int Count = 0;
                foreach (SellingPill sellingPill in functions.sellingPillesList)
                {
                    if (sellingPill.Id == int.Parse(txId.Text))
                    {
                        Count = sellingPill.Soni;
                        sanoq = 1;
                        break;
                    }
                }
                if (sanoq == 1)
                {
                    if (functions.CheckNumber(txUpdatePillCount.Text))
                    {
                        if (int.Parse(txUpdatePillCount.Text) < Count)
                        {
                            int Price = 0;
                            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                            foreach (Pill pill in functions.pillsList)
                            {
                                if (pill.Id == int.Parse(txId.Text))
                                {
                                    Price = pill.Narxi;
                                    pill.Soni = pill.Soni + Count - int.Parse(txUpdatePillCount.Text);
                                }
                                streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                            }
                            streamWriter.Close();
                            StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
                            foreach (SellingPill sellingPill in functions.sellingPillesList)
                            {
                                if (sellingPill.Id == int.Parse(txId.Text))
                                {
                                    sellingPill.Soni = int.Parse(txUpdatePillCount.Text);
                                    sellingPill.Narxi = int.Parse(txUpdatePillCount.Text) * Price;
                                }
                                streamWriter1.WriteLine(sellingPill.Id + "," + sellingPill.Nomi + "," + sellingPill.Soni + "," + sellingPill.Narxi);
                            }
                            streamWriter1.Close();
                            this.Hide();
                            UpdateBasketPillForm updateBasketPillForm = new UpdateBasketPillForm(NewLogin);
                            updateBasketPillForm.StartPosition = FormStartPosition.CenterScreen;
                            updateBasketPillForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Dori soni bunday bo'lishi mumkin emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dori soni bunday bo'lishi mumkin emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bunday Id mavjud emas", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
