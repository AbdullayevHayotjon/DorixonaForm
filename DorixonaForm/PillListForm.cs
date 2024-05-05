using DorixonaForm.Actions;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class PillListForm : Form
    {
        public PillListForm()
        {
            InitializeComponent();
            List<Pill> pill = new List<Pill>();
            string path = @"C:\DorixonaForm\DorixonaForm\.txt files\AllPillList.txt";
            string[] pillList = File.ReadAllLines(path);
            for (int i = 0; i < pillList.Length; i++)
            {
                string[] pillLine = pillList[i].Split(",");
                pill.Add(new Pill { Name = pillLine[1], price = pillLine[2], quantity = pillLine[3] });
            }
            DtgPlist.DataSource = pill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btOrqaga_Click(object sender, EventArgs e)
        {
            SalesmanForm salesmanForm = new SalesmanForm(); 
            salesmanForm.Show();
            this.Hide();
        }
    }
}
