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
            dGVInformations.DataSource = functions.reportSelesPills;
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
            int AllPillCount = 0;
            int AllPillPrice = 0;
            foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
            {
                AllPillCount += reportSelesPill.Soni;
                AllPillPrice += reportSelesPill.Narxi;
            }
            lbAllPillCount.Text = AllPillCount.ToString();
            lbAllPillPrice.Text = AllPillPrice.ToString();
            label4.Text = "0";
            label3.Text = "0";
            label8.Text = "0";
            label7.Text = "0";
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

            string FIO = "";
            int sanoq = 0;
            dGVInformations.DataSource = functions.reportSelesPills;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.Login == txLogin.Text)
                {
                    sanoq = 2;
                    FIO = employe.FIO;
                }
            }
            List<ReportSelesPill> reportSelesPillList = new List<ReportSelesPill>();
            int i = 1;
            foreach (ReportSelesPill reportSelesPill1 in functions.reportSelesPills)
            {
                if (reportSelesPill1.FIO == FIO)
                {
                    reportSelesPillList.Add(new ReportSelesPill() { Id = i++, FIO = reportSelesPill1.FIO, Nomi = reportSelesPill1.Nomi, Soni = reportSelesPill1.Soni, SotilganVaqti = reportSelesPill1.SotilganVaqti, Narxi = reportSelesPill1.Narxi });
                }
            }
            int AllCount = 0;
            int AllPrice = 0;
            foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
            {
                if (FIO == reportSelesPill.FIO)
                {
                    sanoq = 1;
                    AllCount += reportSelesPill.Soni;
                    AllPrice += reportSelesPill.Narxi;
                }
            }
            if (sanoq == 1)
            {
                dGVInformations.DataSource = reportSelesPillList;
                label4.Text = AllCount.ToString();
                label3.Text = AllPrice.ToString();
            }
            else if (sanoq == 2)
            {
                label4.Text = "0";
                label3.Text = "0";
                MessageBox.Show("Hali mahsulot sotmagan", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txLogin.Text.Length == 0)
            {
                label4.Text = "0";
                label3.Text = "0";
            }
            else
            {
                MessageBox.Show("Bunday login mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label4.Text = "0";
                label3.Text = "0";
            }
        }

        private void btResult2_Click(object sender, EventArgs e)
        {
            int AllCount = 0;
            int AllPrice = 0;
            int sanoq = 0;
            DateTime date;
            dGVInformations.DataSource = functions.reportSelesPills;
            List<ReportSelesPill> reportSelesPillList = new List<ReportSelesPill>();
            int i = 1;
            if(DateTime.TryParse(txStartDate.Text, out date) && DateTime.TryParse(txFinishDate.Text, out date))
            {
                foreach (ReportSelesPill reportSelesPill1 in functions.reportSelesPills)
                {
                    if (DateTime.Parse(reportSelesPill1.SotilganVaqti) >= DateTime.Parse(txStartDate.Text) && DateTime.Parse(reportSelesPill1.SotilganVaqti.Substring(0, 10)) <= DateTime.Parse(txFinishDate.Text))
                    {
                        sanoq = 1;
                        AllCount += reportSelesPill1.Soni;
                        AllPrice += reportSelesPill1.Narxi;
                        reportSelesPillList.Add(new ReportSelesPill() { Id = i++, FIO = reportSelesPill1.FIO, Nomi = reportSelesPill1.Nomi, Soni = reportSelesPill1.Soni, SotilganVaqti = reportSelesPill1.SotilganVaqti, Narxi = reportSelesPill1.Narxi });
                    }
                }
            }
            if (sanoq == 1)
            {
                dGVInformations.DataSource = reportSelesPillList;
                label8.Text = AllCount.ToString();
                label7.Text = AllPrice.ToString();
            }
            else if (txStartDate.Text.Length == 0 && txFinishDate.Text.Length == 0)
            {
                label8.Text = "0";
                label7.Text = "0";
            }
            else
            {
                MessageBox.Show("Kiritilgan sanalar noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label8.Text = "0";
                label7.Text = "0";
            }
        }
    }
}
