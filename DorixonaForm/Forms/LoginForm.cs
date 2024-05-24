using DorixonaForm.Actions;
using DorixonaForm.Forms;
using Microsoft.VisualBasic.Logging;

namespace DorixonaForm
{
    public partial class LoginForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Employe employe in functions.employeList)
            {
                if (employe.Login == txLogin.Text && employe.Password == txPassword.Text)
                {
                    sanoq = 1;
                    StreamWriter streamWriter1 = new StreamWriter(functions.AllInformationsPath);
                    foreach (AllInformations allInformations in functions.allInformations)
                    {
                        streamWriter1.WriteLine(allInformations.Id + "," + allInformations.FIO + "," + allInformations.ProcessType + "," + allInformations.Information + "," + allInformations.ProcessTime);
                    }
                    streamWriter1.WriteLine(employe.Id + "," + employe.FIO + "," + InformationType.EmployeEnter + "," + "Profilga kirdi" + "," + DateTime.Now.ToString());
                    streamWriter1.Close();
                    if (employe.EmployeType == EmployeType.Manager.ToString())
                    {
                        this.Hide();
                        ManagerForm manager = new ManagerForm(txLogin.Text);
                        manager.StartPosition = FormStartPosition.CenterScreen;
                        manager.Show();
                        break;
                    }
                    else
                    {
                        this.Hide();
                        SalesmanForm salesmanForm = new SalesmanForm(txLogin.Text);
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
            NewLogPassForm newLogPassForm = new NewLogPassForm(NewLogin);
            newLogPassForm.StartPosition = FormStartPosition.CenterScreen;
            newLogPassForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
