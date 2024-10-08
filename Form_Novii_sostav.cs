using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_7_02._01
{
    public partial class Form_Novii_sostav : Form
    {
        public Form_Novii_sostav()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Klienti form1 = new Form_Klienti();
            form1.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sotrudniki form2 = new Form_Sotrudniki();
            form2.Show();
            this.Hide();
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dogovori form3 = new Form_Dogovori();
            form3.Show();
            this.Hide();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolgnosti form5 = new Form_Dolgnosti();
            form5.Show();
            this.Hide();
        }

        private void предметЗалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Predmet_zaloga form6 = new Form_Predmet_zaloga();
            form6.Show();
            this.Hide();
        }

        private void составToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Sostav form7 = new Form_Sostav();
            form7.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vhod form8 = new Form_Vhod();
            form8.Show();
            this.Hide();
        }
    }
}
