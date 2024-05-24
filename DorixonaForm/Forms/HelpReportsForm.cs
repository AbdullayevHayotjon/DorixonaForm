using DorixonaForm.Actions;
using Microsoft.VisualBasic.Logging;
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
    public partial class HelpReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public HelpReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            dGVEmploye.DataSource = functions.allInformations;
        }

        private void HelpReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btOsish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSort.Text.Length > 0)
                {
                    List<AllInformations> allInformationsList = new List<AllInformations>();
                    foreach (var allInformationsItem in functions.allInformations)
                    {
                        allInformationsList.Add(new AllInformations
                        {
                            Id = allInformationsItem.Id,
                            FIO = allInformationsItem.FIO,
                            ProcessType = allInformationsItem.ProcessType,
                            Information = allInformationsItem.Information,
                            ProcessTime = allInformationsItem.ProcessTime,
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        allInformationsList.Sort((x, y) => x.Id.CompareTo(y.Id));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        allInformationsList.Sort((x, y) =>
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
                    else if (cbSort.Text == "Process type")
                    {
                        allInformationsList.Sort((x, y) => x.ProcessType.CompareTo(y.ProcessType));
                    }
                    else if (cbSort.Text == "Information")
                    {
                        allInformationsList.Sort((x, y) => x.Information.CompareTo(y.Information));
                    }
                    else if (cbSort.Text == "Process time")
                    {
                        allInformationsList.Sort((x, y) => x.ProcessTime.CompareTo(y.ProcessTime));
                    }
                    dGVEmploye.DataSource = allInformationsList;
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
                    List<AllInformations> allInformationsList = new List<AllInformations>();
                    foreach (var allInformationsItem in functions.allInformations)
                    {
                        allInformationsList.Add(new AllInformations
                        {
                            Id = allInformationsItem.Id,
                            FIO = allInformationsItem.FIO,
                            ProcessType = allInformationsItem.ProcessType,
                            Information = allInformationsItem.Information,
                            ProcessTime = allInformationsItem.ProcessTime,
                        });
                    }
                    if (cbSort.Text == "Id")
                    {
                        allInformationsList.Sort((x, y) => y.Id.CompareTo(x.Id));
                    }
                    else if (cbSort.Text == "FIO")
                    {
                        allInformationsList.Sort((x, y) =>
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
                    else if (cbSort.Text == "Process type")
                    {
                        allInformationsList.Sort((x, y) => y.ProcessType.CompareTo(x.ProcessType));
                    }
                    else if (cbSort.Text == "Information")
                    {
                        allInformationsList.Sort((x, y) => y.Information.CompareTo(x.Information));
                    }
                    else if (cbSort.Text == "Process time")
                    {
                        allInformationsList.Sort((x, y) => y.ProcessTime.CompareTo(x.ProcessTime));
                    }
                    dGVEmploye.DataSource = allInformationsList;
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
            dGVEmploye.DataSource = functions.allInformations;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
            foreach (AllInformations allInformations in functions.allInformations)
            {
                streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
            }
            foreach (Employe employe in functions.employeList)
            {
                if (NewLogin == employe.Login)
                {
                    streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.EmployeExit + "," + "Profildan chiqdi" + "," + DateTime.Now.ToString());
                }
            }
            streamWriter1.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Id")
            {
                List<AllInformations> allInformations = new List<AllInformations>();
                foreach (AllInformations allInformation in functions.allInformations)
                {
                    if (allInformation.Id.ToString().Contains(txPillInformation.Text))
                    {
                        allInformations.Add(new AllInformations() { Id = allInformation.Id, FIO = allInformation.FIO, ProcessType = allInformation.ProcessType, Information = allInformation.Information, ProcessTime = allInformation.ProcessTime });
                    }
                }
                dGVEmploye.DataSource = allInformations;
            }
            else if (cbSearch.Text == "FIO")
            {
                List<AllInformations> allInformations = new List<AllInformations>();
                foreach (AllInformations allInformation in functions.allInformations)
                {
                    if (allInformation.FIO.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        allInformations.Add(new AllInformations() { Id = allInformation.Id, FIO = allInformation.FIO, ProcessType = allInformation.ProcessType, Information = allInformation.Information, ProcessTime = allInformation.ProcessTime });
                    }
                }
                dGVEmploye.DataSource = allInformations;
            }
            else if (cbSearch.Text == "ProcessType")
            {
                List<AllInformations> allInformations = new List<AllInformations>();
                foreach (AllInformations allInformation in functions.allInformations)
                {
                    if (allInformation.ProcessType.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        allInformations.Add(new AllInformations() { Id = allInformation.Id, FIO = allInformation.FIO, ProcessType = allInformation.ProcessType, Information = allInformation.Information, ProcessTime = allInformation.ProcessTime });
                    }
                }
                dGVEmploye.DataSource = allInformations;
            }
            else if (cbSearch.Text == "Information")
            {
                List<AllInformations> allInformations = new List<AllInformations>();
                foreach (AllInformations allInformation in functions.allInformations)
                {
                    if (allInformation.Information.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        allInformations.Add(new AllInformations() { Id = allInformation.Id, FIO = allInformation.FIO, ProcessType = allInformation.ProcessType, Information = allInformation.Information, ProcessTime = allInformation.ProcessTime });
                    }
                }
                dGVEmploye.DataSource = allInformations;
            }
            else if (cbSearch.Text == "ProcessTime")
            {
                List<AllInformations> allInformations = new List<AllInformations>();
                foreach (AllInformations allInformation in functions.allInformations)
                {
                    if (allInformation.ProcessTime.ToLower().Contains(txPillInformation.Text.ToLower()))
                    {
                        allInformations.Add(new AllInformations() { Id = allInformation.Id, FIO = allInformation.FIO, ProcessType = allInformation.ProcessType, Information = allInformation.Information, ProcessTime = allInformation.ProcessTime });
                    }
                }
                dGVEmploye.DataSource = allInformations;
            }
            else
            {
                MessageBox.Show("Bo'limdan birini tanlang", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Hours = 0;
            int Minut = 0;
            DateTime Kun1 = DateTime.Parse(dtDay1.Text).Date;
            DateTime Kun2 = DateTime.Parse(dtDay2.Text).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            List<AllInformations> allInformations1 = new List<AllInformations>();
            if (txSalesmanId.Text.Length != 0)
            {
                if (functions.CheckNumber(txSalesmanId.Text))
                {
                    int sanoq = 0;
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        if (allInformations.Id == int.Parse(txSalesmanId.Text))
                        {
                            sanoq = 1;
                        }
                    }
                    if (sanoq == 1)
                    {
                        if (Kun2 >= Kun1)
                        {
                            foreach (AllInformations allInformations in functions.allInformations)
                            {
                                if (allInformations.Id == int.Parse(txSalesmanId.Text) && (allInformations.ProcessType == InformationType.EmployeEnter.ToString() || allInformations.ProcessType == InformationType.EmployeExit.ToString()))
                                {
                                    if (Kun1 <= DateTime.Parse(allInformations.ProcessTime) && DateTime.Parse(allInformations.ProcessTime) <= Kun2)
                                    {
                                        allInformations1.Add(new AllInformations()
                                        {
                                            Id = allInformations.Id,
                                            FIO = allInformations.FIO,
                                            ProcessType = allInformations.ProcessType,
                                            Information = allInformations.Information,
                                            ProcessTime = allInformations.ProcessTime
                                        });
                                    }
                                }
                            }
                            if (allInformations1.Count() % 2 == 0)
                            {
                                for (int i = 0; i < allInformations1.Count() - 1; i += 2)
                                {
                                    Hours += (DateTime.Parse(allInformations1[i + 1].ProcessTime) - DateTime.Parse(allInformations1[i].ProcessTime)).Hours;
                                    Minut += (DateTime.Parse(allInformations1[i + 1].ProcessTime) - DateTime.Parse(allInformations1[i].ProcessTime)).Minutes;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < allInformations1.Count() - 2; i += 2)
                                {
                                    Hours += (DateTime.Parse(allInformations1[i + 1].ProcessTime) - DateTime.Parse(allInformations1[i].ProcessTime)).Hours;
                                    Minut += (DateTime.Parse(allInformations1[i + 1].ProcessTime) - DateTime.Parse(allInformations1[i].ProcessTime)).Minutes;
                                }
                                Hours += (DateTime.Now - DateTime.Parse(allInformations1[allInformations1.Count() - 1].ProcessTime)).Hours;
                                Minut += (DateTime.Now - DateTime.Parse(allInformations1[allInformations1.Count() - 1].ProcessTime)).Minutes;
                            }
                            if (Minut >= 60)
                            {
                                lbHour.Text = (Hours + Minut / 60).ToString();
                                lbMinut.Text = (Minut % 60).ToString();
                            }
                            else
                            {
                                lbHour.Text = Hours.ToString();
                                lbMinut.Text = Minut.ToString();
                            }
                            dGVEmploye.DataSource = allInformations1;
                        }
                        else
                        {
                            MessageBox.Show("Sanalar bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bunday id mavjud emas", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sotuvchi id si bunday bo'lishi mumkin emas", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sotuvchi id sini kiritmadingiz", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void HelpReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
