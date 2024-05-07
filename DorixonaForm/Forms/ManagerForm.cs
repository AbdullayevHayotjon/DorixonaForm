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
    public partial class ManagerForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ManagerForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(NewLogin);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btAddSalesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSalesmanForm addSalesmanForm = new AddSalesmanForm(NewLogin);
            addSalesmanForm.StartPosition = FormStartPosition.CenterScreen;
            addSalesmanForm.Show();
        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            txDeleteSalesmanForm deleteSalesmanForm = new txDeleteSalesmanForm(NewLogin);
            deleteSalesmanForm.StartPosition = FormStartPosition.CenterScreen;
            deleteSalesmanForm.Show();
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
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(NewLogin);
            settingsForm.StartPosition = FormStartPosition.CenterScreen;
            settingsForm.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //foreach (Employe employe in functions.employeList)
            //{
            //    if(NewLogin == employe.Login)
            //    {
            //        lbNewFIO.Text = employe.FIO;
            //    }
            //}
        }
    }
}
