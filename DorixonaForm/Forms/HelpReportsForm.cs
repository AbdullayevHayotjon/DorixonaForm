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
    }
}
