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
    public partial class UpdateBasketPillForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public UpdateBasketPillForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBasketPillForm_Load(object sender, EventArgs e)
        {

        }
    }
}
