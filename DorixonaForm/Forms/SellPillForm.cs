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
