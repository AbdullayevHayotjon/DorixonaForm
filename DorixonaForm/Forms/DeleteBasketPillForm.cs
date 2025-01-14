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
    public partial class DeleteBasketPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeleteBasketPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dataGridView1.DataSource = functions.sellingPillesList;
        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBasketPillForm_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {

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

        private void btUpdatePill_Click_1(object sender, EventArgs e)
        {
            if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                int Count = 0;
                foreach (SellingPill sellingPill in functions.sellingPillesList)
                {
                    if (sellingPill.Id == int.Parse(txId.Text))
                    {
                        sanoq = 1;
                        Count = sellingPill.Soni;
                    }
                }
                if (sanoq == 1)
                {
                    StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                    foreach (Pill pill in functions.pillsList)
                    {
                        if (pill.Id == int.Parse(txId.Text))
                        {
                            pill.Soni = pill.Soni + Count;
                        }
                        streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                    }
                    streamWriter.Close();
                    StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
                    foreach (SellingPill pill in functions.sellingPillesList)
                    {
                        if (pill.Id == int.Parse(txId.Text))
                        {
                            continue;
                        }
                        streamWriter1.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Narxi);
                    }
                    streamWriter1.Close();
                    this.Hide();
                    DeleteBasketPillForm deleteBasketPillForm = new DeleteBasketPillForm(NewLogin);
                    deleteBasketPillForm.StartPosition = FormStartPosition.CenterScreen;
                    deleteBasketPillForm.Show();
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

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void DeleteBasketPillForm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
