using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayımatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayımatikk forma = new sayımatikk();
            forma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayımatiko formb = new sayımatiko();
            formb.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayımatikz formc = new sayımatikz();
            formc.Show();
            this.Hide();
        }
    }
}
