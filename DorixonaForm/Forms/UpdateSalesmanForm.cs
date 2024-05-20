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
    public partial class UpdateSalesmanForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdateSalesmanForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            List<Employe> employes = new List<Employe>();
            int i = 1;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.EmployeType == EmployeType.Manager.ToString())
                {
                    continue;
                }
                employes.Add(new Employe() { Id = i++, FIO = employe.FIO, Login = employe.Login, Password = employe.Password, PhoneNumber = employe.PhoneNumber });
            }
            dGVUpdateEmploye.DataSource = employes;
        }

        private void UpdateSalesmanForm_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.Show();
            this.Hide();
        }

        private void dGVEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btPlacement_Click(object sender, EventArgs e)
        {
            if (txId.Text.Length == 0)
            {
                txUpdateFio.Clear();
                txUpdateTel.Clear();
                txUpdateTel.Clear();
                txUpdatePassword.Clear();
            }
            else if (functions.CheckNumber(txId.Text))
            {
                int sanoq = 0;
                foreach (Employe employe in functions.employeList)
                {
                    if (int.Parse(txId.Text) == employe.Id)
                    {
                        sanoq = 1;
                        txUpdateFio.Text = employe.FIO;
                        txUpdateTel.Text = employe.PhoneNumber.ToString();
                        txUpdateLog.Text = employe.Login.ToString();
                        txUpdatePassword.Text = employe.Password.ToString();
                        break;
                    }

                }
                if (sanoq == 0)
                {
                    MessageBox.Show("Bunday Id topilmadi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bunday Id topilmadi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDeleteSalesman_Click(object sender, EventArgs e)
        {

        }
    }
}
