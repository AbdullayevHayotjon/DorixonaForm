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
using static System.Net.WebRequestMethods;

namespace DorixonaForm.Forms
{
    public partial class AddPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public AddPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void AddPillForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {
            if (txAddPillName.Text.Length > 0 && txAddPillCount.Text.Length > 0 && txAddPillPrice.Text.Length > 0)
            {
                int sanoq = 0;
                foreach (Pill pill in functions.pillsList)
                {
                    if(txAddPillName.Text.ToLower() == pill.Nomi.ToLower())
                    {
                        sanoq = 1;
                    }
                }
                if(sanoq == 0)
                {
                    int i = 1;
                    StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                    foreach (Pill pill in functions.pillsList)
                    {
                        streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Narxi);
                    }
                    streamWriter.WriteLine(i + "," + txAddPillName.Text + "," + txAddPillCount.Text + "," + txAddPillPrice.Text);
                    streamWriter.Close();
                    MessageBox.Show($"Dori qo'shildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                    salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                    salesmanForm.Show();
                }
                else
                {
                    MessageBox.Show("Bu dori oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bo'sh qiymat kiritish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
