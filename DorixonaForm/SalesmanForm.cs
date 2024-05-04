using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm
{
    public partial class SalesmanForm : Form
    {
        public SalesmanForm()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }
    }
}
