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
    }
}
