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
            dGVEmploye.DataSource = functions.reportSelesPills;
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


        }

        private void btResult2_Click(object sender, EventArgs e)
        {

        }

        private void dGVInformations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            if (cbSearch.Text == "SotuvchiId")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.SotuvchiId.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "FIO")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.FIO.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "DoriId")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.DoriId.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Nomi")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Nomi.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Soni")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Soni.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "SotilganVaqti")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.SotilganVaqti.Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else if (cbSearch.Text == "Narxi")
            {
                List<ReportSelesPill> reportSelesPill = new List<ReportSelesPill>();
                foreach (ReportSelesPill reportSelePill in functions.reportSelesPills)
                {
                    if (reportSelePill.Narxi.ToString().Contains(txPillInformation.Text))
                    {
                        reportSelesPill.Add(new ReportSelesPill() { SotuvchiId = reportSelePill.SotuvchiId, FIO = reportSelePill.FIO, DoriId = reportSelePill.DoriId, Nomi = reportSelePill.Nomi, Soni = reportSelePill.Soni, SotilganVaqti = reportSelePill.SotilganVaqti, Narxi = reportSelePill.Narxi });
                    }
                }
                dGVEmploye.DataSource = reportSelesPill;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportsForm = new ReportsForm(NewLogin);
            reportsForm.StartPosition = FormStartPosition.CenterScreen;
            reportsForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Price = 0;
            int Count = 0;
            DateTime Kun1 = DateTime.Parse(dtDay1.Text).Date;
            DateTime Kun2 = DateTime.Parse(dtDay2.Text).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            List<ReportSelesPill> list = new List<ReportSelesPill>();
            if (txPillId.Text.Length == 0 && txSalesmanId.Text.Length == 0)
            {
                if (Kun2 >= Kun1)
                {
                    foreach (ReportSelesPill salesmanReport in functions.reportSelesPills)
                    {
                        if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                        {
                            list.Add(new ReportSelesPill() { SotuvchiId = salesmanReport.SotuvchiId, FIO = salesmanReport.FIO, DoriId = salesmanReport.DoriId, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                            Price += salesmanReport.Narxi;
                            Count += salesmanReport.Soni;
                        }
                    }
                    lbPrice.Text = Price.ToString();
                    lbCount.Text = Count.ToString();
                    dGVEmploye.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txPillId.Text.Length != 0 && txSalesmanId.Text.Length != 0)
            {
                if (functions.CheckNumber(txSalesmanId.Text))
                {
                    int sanoq = 0;
                    foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
                    {
                        if (int.Parse(txSalesmanId.Text) == reportSelesPill.SotuvchiId)
                        {
                            sanoq = 1;
                        }
                    }
                    if (sanoq == 1)
                    {
                        if (functions.CheckNumber(txPillId.Text))
                        {
                            foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
                            {
                                if (int.Parse(txPillId.Text) == reportSelesPill.DoriId)
                                {
                                    sanoq = 2;
                                }
                            }
                            if (sanoq == 2)
                            {
                                if (Kun2 >= Kun1)
                                {
                                    foreach (ReportSelesPill salesmanReport in functions.reportSelesPills)
                                    {
                                        if (int.Parse(txPillId.Text) == salesmanReport.DoriId && int.Parse(txSalesmanId.Text) == salesmanReport.SotuvchiId)
                                        {
                                            if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                                            {
                                                list.Add(new ReportSelesPill() { SotuvchiId = salesmanReport.SotuvchiId, FIO = salesmanReport.FIO, DoriId = salesmanReport.DoriId, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                                                Price += salesmanReport.Narxi;
                                                Count += salesmanReport.Soni;
                                            }
                                        }
                                    }
                                    lbPrice.Text = Price.ToString();
                                    lbCount.Text = Count.ToString();
                                    dGVEmploye.DataSource = list;
                                }
                                else
                                {
                                    MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bunday dori idsi mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dori Idsi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bunday sotuvchi idsi mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sotuvchi Idsi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txPillId.Text.Length == 0 && txSalesmanId.Text.Length != 0)
            {
                if (functions.CheckNumber(txSalesmanId.Text))
                {
                    int sanoq = 0;
                    foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
                    {
                        if (int.Parse(txSalesmanId.Text) == reportSelesPill.SotuvchiId)
                        {
                            sanoq = 1;
                        }
                    }
                    if (sanoq == 1)
                    {
                        if (Kun2 >= Kun1)
                        {
                            foreach (ReportSelesPill salesmanReport in functions.reportSelesPills)
                            {
                                if (int.Parse(txSalesmanId.Text) == salesmanReport.SotuvchiId)
                                {
                                    if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                                    {
                                        list.Add(new ReportSelesPill() { SotuvchiId = salesmanReport.SotuvchiId, FIO = salesmanReport.FIO, DoriId = salesmanReport.DoriId, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                                        Price += salesmanReport.Narxi;
                                        Count += salesmanReport.Soni;
                                    }
                                }
                            }
                            lbPrice.Text = Price.ToString();
                            lbCount.Text = Count.ToString();
                            dGVEmploye.DataSource = list;
                        }
                        else
                        {
                            MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bunday sotuvchi idsi mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sotuvchi Idsi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txSalesmanId.Text.Length == 0 && txPillId.Text.Length != 0)
            {
                if (functions.CheckNumber(txPillId.Text))
                {
                    int sanoq = 0;
                    foreach (ReportSelesPill reportSelesPill in functions.reportSelesPills)
                    {
                        if (int.Parse(txPillId.Text) == reportSelesPill.DoriId)
                        {
                            sanoq = 1;
                        }
                    }
                    if (sanoq == 1)
                    {
                        if (Kun2 >= Kun1)
                        {
                            foreach (ReportSelesPill salesmanReport in functions.reportSelesPills)
                            {
                                if (int.Parse(txPillId.Text) == salesmanReport.DoriId)
                                {
                                    if (Kun1 <= DateTime.Parse(salesmanReport.SotilganVaqti) && DateTime.Parse(salesmanReport.SotilganVaqti) <= Kun2)
                                    {
                                        list.Add(new ReportSelesPill() { SotuvchiId = salesmanReport.SotuvchiId, FIO = salesmanReport.FIO, DoriId = salesmanReport.DoriId, Nomi = salesmanReport.Nomi, Soni = salesmanReport.Soni, SotilganVaqti = salesmanReport.SotilganVaqti, Narxi = salesmanReport.Narxi });
                                        Price += salesmanReport.Narxi;
                                        Count += salesmanReport.Soni;
                                    }
                                }
                            }
                            lbPrice.Text = Price.ToString();
                            lbCount.Text = Count.ToString();
                            dGVEmploye.DataSource = list;
                        }
                        else
                        {
                            MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bunday dori idsi mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dori Idsi bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btOsish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    List<ReportSelesPill> reportSelesPillList = new List<ReportSelesPill>();
                    foreach (var reportSelesPillsItem in functions.reportSelesPills)
                    {
                        reportSelesPillList.Add(new ReportSelesPill
                        {
                            SotuvchiId = reportSelesPillsItem.SotuvchiId,
                            FIO = reportSelesPillsItem.FIO,
                            DoriId = reportSelesPillsItem.DoriId,
                            Nomi = reportSelesPillsItem.Nomi,
                            Soni = reportSelesPillsItem.Soni,
                            SotilganVaqti = reportSelesPillsItem.SotilganVaqti,
                            Narxi = reportSelesPillsItem.Narxi
                        });
                    }
                    if (cbSort.Text == "Sotuvchi Id")
                    {
                        reportSelesPillList.Sort((x, y) => x.SotuvchiId.CompareTo(y.SotuvchiId));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        reportSelesPillList.Sort((x, y) =>
                        {
                            if (x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(x.FIO, y.FIO, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Dori Id")
                    {
                        reportSelesPillList.Sort((x, y) => x.DoriId.CompareTo(y.DoriId));
                    }
                    else if (cbSort.Text == "Nomi")
                    {
                        reportSelesPillList.Sort((x, y) => x.Nomi.CompareTo(y.Nomi));
                    }
                    else if (cbSort.Text == "Soni")
                    {
                        reportSelesPillList.Sort((x, y) => x.Soni.CompareTo(y.Soni));
                    }
                    else if (cbSort.Text == "Sotilgan vaqti")
                    {
                        reportSelesPillList.Sort((x, y) => x.SotilganVaqti.CompareTo(y.SotilganVaqti));
                    }
                    else if (cbSort.Text == "Narxi")
                    {
                        reportSelesPillList.Sort((x, y) => x.Narxi.CompareTo(y.Narxi));
                    }
                    dGVEmploye.DataSource = reportSelesPillList;
                }
                else
                {
                    MessageBox.Show("Xatolik mavjud tekshirib qaytadan kiriting.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Noto'g'ri formatda qiymat kiritildi.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Faylda xatolik: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik: " + ex.Message);
            }
        }

        private void btKamayish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    List<ReportSelesPill> reportSelesPillList = new List<ReportSelesPill>();
                    foreach (var reportSelesPillsItem in functions.reportSelesPills)
                    {
                        reportSelesPillList.Add(new ReportSelesPill
                        {
                            SotuvchiId = reportSelesPillsItem.SotuvchiId,
                            FIO = reportSelesPillsItem.FIO,
                            DoriId = reportSelesPillsItem.DoriId,
                            Nomi = reportSelesPillsItem.Nomi,
                            Soni = reportSelesPillsItem.Soni,
                            SotilganVaqti = reportSelesPillsItem.SotilganVaqti,
                            Narxi = reportSelesPillsItem.Narxi
                        });
                    }
                    if (cbSort.Text == "Sotuvchi Id")
                    {
                        reportSelesPillList.Sort((x, y) => y.SotuvchiId.CompareTo(x.SotuvchiId));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        reportSelesPillList.Sort((x, y) =>
                        {
                            if (y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && !x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return -1;
                            }
                            else if (!y.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase) && x.FIO.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                            {
                                return 1;
                            }
                            else
                            {
                                return string.Compare(y.FIO, x.FIO, StringComparison.OrdinalIgnoreCase);
                            }
                        });
                    }
                    else if (cbSort.Text == "Dori Id")
                    {
                        reportSelesPillList.Sort((x, y) => y.DoriId.CompareTo(x.DoriId));
                    }
                    else if (cbSort.Text == "Nomi")
                    {
                        reportSelesPillList.Sort((x, y) => y.Nomi.CompareTo(x.Nomi));
                    }
                    else if (cbSort.Text == "Soni")
                    {
                        reportSelesPillList.Sort((x, y) => y.Soni.CompareTo(x.Soni));
                    }
                    else if (cbSort.Text == "Sotilgan vaqti")
                    {
                        reportSelesPillList.Sort((x, y) => y.SotilganVaqti.CompareTo(x.SotilganVaqti));
                    }
                    else if (cbSort.Text == "Narxi")
                    {
                        reportSelesPillList.Sort((x, y) => y.Narxi.CompareTo(x.Narxi));
                    }
                    dGVEmploye.DataSource = reportSelesPillList;
                }
                else
                {
                    MessageBox.Show("Xatolik mavjud tekshirib qaytadan kiriting.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Noto'g'ri formatda qiymat kiritildi.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Faylda xatolik: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik: " + ex.Message);
            }
        }

        private void btQaytarish_Click(object sender, EventArgs e)
        {
            dGVEmploye.DataSource = functions.reportSelesPills;
        }
    }
}
