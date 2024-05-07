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
        }

        private void SellPillForm_Load(object sender, EventArgs e)
        {

        }

        private void btConfirmation_Click(object sender, EventArgs e)
        {
            int i = 1;
            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
            foreach (Pill pill in functions.pillsList)
            {
                foreach (Pill pill1 in functions.sellingPillesList)
                {
                    if(pill.Nomi == pill1.Nomi)
                    {
                        pill.Soni = pill.Soni - pill1.Soni;
                    }
                }
                if(pill.Soni == 0)
                {
                    continue;
                }
                streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Narxi);
            }
            streamWriter.Close();
            MessageBox.Show($"Sotildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StreamWriter streamWriter1 = new StreamWriter(functions.SellingPillesListPath);
            streamWriter1.Close();
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }
    }
}
