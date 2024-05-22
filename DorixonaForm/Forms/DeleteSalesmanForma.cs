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
    public partial class DeleteSalesmanForma : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public DeleteSalesmanForma(string login)
        {
            NewLogin = login;
            InitializeComponent();
        }

        private void DeleteSalesmanForma_Load(object sender, EventArgs e)
        {

        }
    }
}
