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
    public partial class SalesmanReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public List<SalesmanReport> salesmanReports = new List<SalesmanReport>();
        public SalesmanReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            string FIO = "";
            foreach (Employe employe in functions.employeList)
            {
                if (NewLogin == employe.Login)
                {
                    FIO = employe.FIO;
                }
            }
            foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
            {
                if (FIO == reportSelesPill.FIO)
                {
                    salesmanReports.Add(new SalesmanReport() { Id = reportSelesPill.DoriId, Nomi = reportSelesPill.Nomi, Soni = reportSelesPill.Soni, SotilganVaqti = reportSelesPill.SotilganVaqti, Narxi = reportSelesPill.Narxi});
                }
            }
            dataGridView1.DataSource = salesmanReports;
        }

        private void SalesmanReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
