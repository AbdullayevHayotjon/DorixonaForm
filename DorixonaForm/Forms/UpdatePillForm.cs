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
    public partial class UpdatePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdatePillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void UpdatePillForm_Load(object sender, EventArgs e)
        {

        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Pill pill in functions.pillsList)
            {
                if(txUpdatePillName.Text.ToLower() == pill.Nomi.ToLower())
                {
                    sanoq = 1;
                    pill.Soni = int.Parse(txUpdatePillCount.Text);
                    pill.Narxi = int.Parse(txUpdatePillPrice.Text);
                }
            }
            if (sanoq == 1)
            {
                int i = 1;
                StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                foreach (Pill pill in functions.pillsList)
                {
                    streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Narxi);
                }
                streamWriter.Close();
                MessageBox.Show($"Dori yangilandi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                salesmanForm.Show();
            }
            else
            {
                MessageBox.Show("Bu dori mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
