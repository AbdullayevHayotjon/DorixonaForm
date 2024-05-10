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
    public partial class ChangePillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ChangePillForm(string login)
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

        private void AddPillForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.Login == NewLogin)
                {
                    if (employe.EmployeType == EmployeType.Manager.ToString())
                    {
                        sanoq = 1;
                    }
                    else
                    {
                        sanoq = 2;
                    }
                    break;
                }
            }
            if (sanoq == 1)
            {
                this.Hide();
                ManagerForm managerForm = new ManagerForm(NewLogin);
                managerForm.StartPosition = FormStartPosition.CenterScreen;
                managerForm.Show();
            }
            else
            {
                this.Hide();
                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                salesmanForm.Show();
            }
        }

        private void btAddPill_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Pill pill in functions.pillsList)
            {
                if (pill.Nomi.ToLower() == txAddPillName.Text.ToLower())
                {
                    sanoq = 1;
                }
            }
            if (sanoq == 0)
            {
                if (functions.CheckProbel(txAddPillName.Text))
                {
                    if (functions.CheckNumber(txAddPillCount.Text))
                    {
                        if (functions.CheckNumber(txLifeTime.Text))
                        {
                            if (functions.CheckNumber(txAddPillPrice.Text))
                            {
                                StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                                int i = 1;
                                foreach (Pill pill in functions.pillsList)
                                {
                                    streamWriter.WriteLine((i++) + "," + pill.Nomi + "," + pill.Soni + "," + pill.Muddati + "," + pill.Narxi + "," + pill.QoshilganSana);
                                }
                                streamWriter.WriteLine(i + "," + txAddPillName.Text + "," + txAddPillCount.Text + "," + txLifeTime.Text + "," + txAddPillPrice.Text + "," + DateTime.Now.ToString());
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
                                        streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.AddPill + "," + $"|Nomi: {txAddPillName.Text}|Soni: {txAddPillCount.Text}|Muddati: {txLifeTime.Text}|Narxi: {txAddPillPrice.Text}|" + "," + DateTime.Now.ToString());
                                    }
                                }
                                streamWriter1.Close();
                                MessageBox.Show($"Dori qo'shildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                                salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                                salesmanForm.Show();
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
            else
            {
                MessageBox.Show("Bu dori hali tugamagan", "Ma'lumot!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btUpdatePill_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Pill pill in functions.pillsList)
            {
                if (txUpdatePillName.Text.ToLower() == pill.Nomi.ToLower())
                {
                    sanoq = 1;
                }
            }
            if (sanoq == 1)
            {
                if (functions.CheckNumber(txUpdatePillCount.Text))
                {
                    if (functions.CheckNumber(txUpdatePillLifeTime.Text))
                    {
                        if (functions.CheckNumber(txUpdatePillPrice.Text))
                        {
                            foreach (Pill pill in functions.pillsList)
                            {
                                if (txUpdatePillName.Text.ToLower() == pill.Nomi.ToLower())
                                {
                                    pill.Soni = int.Parse(txUpdatePillCount.Text);
                                    pill.Muddati = int.Parse(txUpdatePillLifeTime.Text);
                                    pill.Narxi = int.Parse(txUpdatePillPrice.Text);
                                }
                            }
                            int i = 1;
                            StreamWriter streamWriter = new StreamWriter(functions.PillsListPath);
                            foreach (Pill pill in functions.pillsList)
                            {
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
                                    streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.UpdatePill + "," + $"|Nomi: {txUpdatePillName.Text}|Soni: {txUpdatePillCount.Text}|Muddati: {txUpdatePillLifeTime.Text}|Narxi: {txUpdatePillPrice.Text}|" + "," + DateTime.Now.ToString());
                                }
                            }
                            streamWriter1.Close();
                            MessageBox.Show($"Dori yangilandi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
                            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                            salesmanForm.Show();
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
                MessageBox.Show("Bunday dori mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
