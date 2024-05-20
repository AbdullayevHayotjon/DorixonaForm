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
    public partial class SalesmanReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public SalesmanReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void SalesmanReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanForm salesmanForm = new SalesmanForm(NewLogin);
            salesmanForm.StartPosition = FormStartPosition.CenterScreen;
            salesmanForm.Show();
        }
    }
}
