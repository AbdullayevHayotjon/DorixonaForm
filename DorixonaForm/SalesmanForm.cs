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

        private void btAddPill_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {

        }

        private void btDeletePill_Click(object sender, EventArgs e)
        {

        }

        private void btPillList_Click(object sender, EventArgs e)
        {
            PillListForm pillForm = new PillListForm();
            pillForm.Show();
            this.Hide();
        }
    }
}
