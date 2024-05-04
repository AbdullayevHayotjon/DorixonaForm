using DorixonaForm.Actions;
using DorixonaForm.Forms;
using Microsoft.VisualBasic.Logging;

namespace DorixonaForm
{
    public partial class LoginForm : Form
    {
        Functions functions = new Functions();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.Login == txLogin.Text && employe.Password == txPassword.Text)
                {
                    sanoq = 1;
                    if(employe.EmployeType == EmployeType.Manager.ToString())
                    {
                        this.Hide();
                        ManagerForm manager = new ManagerForm();
                        manager.StartPosition = FormStartPosition.CenterScreen;
                        manager.Show();
                        break;
                    }
                    else
                    {
                        this.Hide();
                        SalesmanForm salesmanForm = new SalesmanForm();
                        salesmanForm.StartPosition = FormStartPosition.CenterScreen;
                        salesmanForm.Show();
                        break;
                    }
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Login yoki parol xato!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewLogPassForm newLogPassForm = new NewLogPassForm();
            newLogPassForm.StartPosition = FormStartPosition.CenterScreen;
            newLogPassForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}