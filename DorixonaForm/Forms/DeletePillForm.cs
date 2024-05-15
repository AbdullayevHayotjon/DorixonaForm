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
    public partial class DeletePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeletePillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            foreach (Employe employe1 in functions.employeList)
            {
                if (employe1.Login == NewLogin)
                {
                    lbFIO.Text = employe1.FIO;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btDeletePill_Click(object sender, EventArgs e)
        {
            int sanoq = 0, i = 1;
            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
            foreach (Pill pill in functions.pillsList)
            {
                if (txDeletePillName.Text.ToLower() == pill.Nomi.ToLower())
                {
                    sanoq = 1;
                    continue;
                }
                streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
            }
            streamWriter.Close();
            if (sanoq == 1)
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
                        streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.DeletePill + "," + $"{txDeletePillName.Text} nomli dori o'chirildi" + "," + DateTime.Now.ToString());
                    }
                }
                streamWriter1.Close();
                MessageBox.Show($"Dori o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                salesmanForm.Show();
            }
            else
            {
                MessageBox.Show("Bunday dori mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
