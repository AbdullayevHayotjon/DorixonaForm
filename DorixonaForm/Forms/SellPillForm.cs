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
    public partial class SellPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public SellPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dGWSellPill.DataSource = functions.sellingPillesList;
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
        }

        private void SellPillForm_Load(object sender, EventArgs e)
        {

        }

        private void btConfirmation_Click(object sender, EventArgs e)
        {
            int i = 1;
            string FIO = "";
            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
            foreach (Pill pill in functions.pillsList)
            {
                foreach (SellingPill pill1 in functions.sellingPillesList)
                {
                    if (pill.Nomi == pill1.Nomi)
                    {
                        pill.Soni = pill.Soni - pill1.Soni;
                    }
                }
                if (pill.Soni == 0)
                {
                    continue;
                }
                streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
            }
            streamWriter.Close();
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
                    FIO = employe.FIO;
                }
            }
            foreach (SellingPill sellingPill in functions.sellingPillesList)
            {
                if (sellingPill.Nomi != "Jami")
                {
                    streamWriter1.WriteLine((j++) + "," + FIO + "," + InformationType.SalesPill + "," + $"|Nomi: {sellingPill.Nomi}|Soni: {sellingPill.Soni}|Narxi: {sellingPill.Narxi}|" + "," + DateTime.Now.ToString());
                }
            }
            streamWriter1.Close();
            j = 1;
            StreamWriter streamWriter3 = new StreamWriter(functions.ReportSelesPillsPath);
            foreach (ReportSelesPill selesPill in functions.reportSelesPills)
            {
                streamWriter3.WriteLine((j++) + "," + selesPill.FIO + "," + selesPill.Nomi + "," + selesPill.Soni + "," + selesPill.SotilganVaqti + "," + selesPill.Narxi);
            }
            foreach (SellingPill sellingPill in functions.sellingPillesList)
            {
                if (sellingPill.Nomi != "Jami")
                {
                    streamWriter3.WriteLine((j++) + "," + FIO + "," + sellingPill.Nomi + "," + sellingPill.Soni + "," + DateTime.Now.ToString() + "," + sellingPill.Narxi);
                }
            }
            streamWriter3.Close();
            MessageBox.Show($"Sotildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StreamWriter streamWriter2 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter2.Close();
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(functions.SellingPillesListPath);
            streamWriter.Close();
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void btAddBox_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFIO_Click(object sender, EventArgs e)
        {

        }
    }
}
