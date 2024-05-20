using DorixonaForm.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorixonaForm.Forms
{
    public partial class ReportsForm : Form
    {
        Functions functions = new Functions();
        public string NewLogin { get; set; }
        public ReportsForm(string login)
        {
            NewLogin = login;
            InitializeComponent();
            int AllPillCount = 0;
            int AllPillPrice = 0;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm(NewLogin);
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void txStartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btResult1_Click(object sender, EventArgs e)
        {

            
        }

        private void btResult2_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVInformations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
