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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DorixonaForm.Forms
{
    public partial class DeleteSalesmanForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeleteSalesmanForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {
            //string FIO = "", PhoneNumber = "";
            //if (functions.CheckNumber(txDeletePhoneNumber.Text) && txDeletePhoneNumber.Text.Length == 9)
            //{
            //    if (txDeleteSmsPassword.Text == SmsPassword.ToString())
            //    {
            //        StreamWriter streamWriter = new StreamWriter(functions.EmployesListPath);
            //        foreach (Employe employe in functions.employeList)
            //        {
            //            if (txDeletePhoneNumber.Text == employe.PhoneNumber)
            //            {
            //                PhoneNumber = employe.PhoneNumber;
            //                FIO = employe.FIO;
            //                continue;
            //            }
            //            streamWriter.WriteLine(employe.Id + "," + employe.FIO + "," + employe.Login + "," + employe.Password + "," + employe.PhoneNumber + "," + employe.EmployeType);
            //        }
            //        streamWriter.Close();
            //        MessageBox.Show($"Sotuvchi o'chirildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
            //        int j = 1;
            //        foreach (AllInformations allInformations in functions.allInformations)
            //        {
            //            streamWriter1.WriteLine((j++) + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
            //        }
            //        foreach (Employe employe in functions.employeList)
            //        {
            //            if (NewLogin == employe.Login)
            //            {
            //                streamWriter1.WriteLine(j + "," + employe.FIO + "," + InformationType.DeteleSalesman + "," + $"|FIO: {FIO}|Telefon raqami: {PhoneNumber}|" + "," + DateTime.Now.ToString());
            //            }
            //        }
            //        streamWriter1.Close();
            //        Thread.Sleep(2000);
            //        MessageBox.Show($"Muvaffaqqiyatli o'chirildingiz", "dori.uz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Hide();
            //        ManagerForm managerForm = new ManagerForm(NewLogin);
            //        managerForm.StartPosition = FormStartPosition.CenterScreen;
            //        managerForm.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tasdiqlash kodi noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Telefon raqam bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void txSendPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteSalesmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
