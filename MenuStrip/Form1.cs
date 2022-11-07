using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void namaBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form2"] as Form2) == null);
            
            Form2 nama = new Form2();
            nama.Show();
            this.Hide();
        }

        private void namaBarangToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
