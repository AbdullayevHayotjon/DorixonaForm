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
    public partial class ManagerForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ManagerForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            List<Employe> employes = new List<Employe>();
            int i = 1;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.EmployeType == EmployeType.Manager.ToString())
                {
                    continue;
                }
                employes.Add(new Employe() { Id = i++, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber });
            }
            dGVEmploye.DataSource = employes;
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
            dGVInformations.DataSource = functions.allInformations;
        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void btAddSalesman_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {

        }

        private void btReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportsForm = new ReportsForm(NewLogin);
            reportsForm.StartPosition = FormStartPosition.CenterScreen;
            reportsForm.Show();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbFIO_Click(object sender, EventArgs e)
        {

        }

        private void lnklSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeSalesmanForm addSalesmanForm = new ChangeSalesmanForm(NewLogin);
            addSalesmanForm.StartPosition = FormStartPosition.CenterScreen;
            addSalesmanForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }
    }
}
