using DorixonaForm.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm.Forms
{
    public partial class ReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dGVEmploye.DataSource = functions.reportSelesPills;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void txStartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btResult1_Click(object sender, EventArgs e)
        {


        }

        private void btResult2_Click(object sender, EventArgs e)
        {

        }

        private void dGVInformations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            if (cbSearch.Text == "SotuvchiId")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.SotuvchiId.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "FIO")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.FIO.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "DoriId")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.DoriId.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Nomi")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Nomi.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Soni")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Soni.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "SotilganVaqti")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.SotilganVaqti.Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Narxi")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Narxi.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportsForm = new ReportsForm(NewLogin);
            reportsForm.StartPosition = FormStartPosition.CenterScreen;
            reportsForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             
        }
    }
}
