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
    public partial class UpdatePillForm : Form
    {
        public string NewLogin { get; set; }
        public UpdatePillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void UpdatePillForm_Load(object sender, EventArgs e)
        {

        }
    }
}
