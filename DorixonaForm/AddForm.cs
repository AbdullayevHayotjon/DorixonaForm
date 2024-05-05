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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            string path = @"C:\DorixonaForm\DorixonaForm\.txt files\AllPillList.txt";
            string[] Id = File.ReadAllLines(path);
            string ReadPath = File.ReadAllText(path);
            if (txName.Text.Length > 0 && txPrice.Text.Length > 0 && txQuantity.Text.Length > 0)
            {
                if (ReadPath.Contains(txName.Text))
                {
                    MessageBox.Show("Bu dori oldindan mavjud!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.AppendAllText(path, Id.Length.ToString()
                                                   + "," + txName.Text
                                                   + "," + txPrice.Text
                                                   + "," + txQuantity.Text
                                                   + "\n");
                    MessageBox.Show("Dori muvaffaqiyatli qoshildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Malumotlarni toliq kiriting!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btOrqaga_Click(object sender, EventArgs e)
        {
            SalesmanForm salesmanForm = new SalesmanForm();
            salesmanForm.Show();
            this.Hide();
        }
    }
}
