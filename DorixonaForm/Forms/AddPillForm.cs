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
    public partial class AddPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public AddPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {
            if (functions.CheckProbel(txAddPillName.Text))
            {
                if (functions.CheckNumber(txAddPillCount.Text))
                {
                    if (functions.CheckNumber(txLifeTime.Text))
                    {
                        if (functions.CheckNumber(txAddPillPrice.Text))
                        {
                            int Id = 0;
                            int sanoq = 0;
                            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                            foreach (Pill pill in functions.pillsList)
                            {
                                if (txAddPillName.Text.ToLower() == pill.Nomi.ToLower() && int.Parse(txLifeTime.Text) == pill.Muddati && int.Parse(txAddPillPrice.Text) == pill.Narxi)
                                {
                                    sanoq = 1;
                                    pill.Soni = pill.Soni + int.Parse(txAddPillCount.Text);
                                    pill.QoshilganSana = DateTime.Now;
                                }
                                streamWriter.WriteLine(pill.Id + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                                Id = pill.Id;
                            }
                            if (sanoq == 0)
                            {
                                streamWriter.WriteLine((Id + 1) + "," + txAddPillName.Text + "," + txAddPillCount.Text + "," + txLifeTime.Text + "," + txAddPillPrice.Text + "," + DateTime.Now.ToString());
                            }
                            streamWriter.Close();
                            int Id1 = 0;
                            StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                            foreach (AllInformations allInformations in functions.allInformations)
                            {
                                streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                                Id1 = Id;
                            }
                            foreach (Employe employe in functions.employeList)
                            {
                                if (NewLogin == employe.Login)
                                {
                                    streamWriter1.WriteLine((Id1 + 1) + "," + employe.FIO + "," + InformationType.AddPill + "," + $"|Nomi: {txAddPillName.Text}|Soni: {txAddPillCount.Text}|Muddati: {txLifeTime.Text}|Narxi: {txAddPillPrice.Text}|" + "," + DateTime.Now.ToString());
                                }
                            }
                            streamWriter1.Close();
                            MessageBox.Show($"Dori qo'shildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Dori narxi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dori muddati bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dori soni bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dori nomi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }

        private void AddPillForm_Load(object sender, EventArgs e)
        {

        }
    }
}
